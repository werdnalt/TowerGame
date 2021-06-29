using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour, ChildTriggerable
{
    public GameObject projectile;
    public float timeBetweenShots;
    public float projectileSpeed;
    public int maxAmmo;
    public int costToReload;
    public int damage;
    public bool isEmpty;
    public int owner;

    private Queue<GameObject> minionsToShoot = new Queue<GameObject>();
    private float timeOfLastShot;
    private int currentAmmo;
    private float predictionSamplesPerSecond = 10;
    private float predictionSecondsLookAhead = 1;

    void Start()
    {
        timeOfLastShot = -float.MaxValue;
        currentAmmo = maxAmmo;
        isEmpty = false;
    }

    void Update()
    {
        if (Time.time - timeOfLastShot >= timeBetweenShots && minionsToShoot.Count > 0 && currentAmmo >= 1) Shoot(minionsToShoot.Peek().GetComponent<Minion>());
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Minion minion = other.gameObject.GetComponent<Minion>();
        if (minion && minion.owner != owner) minionsToShoot.Enqueue(other.gameObject);
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        Minion minion = other.gameObject.GetComponent<Minion>();
        if (minion && minion.owner != owner) minionsToShoot.Dequeue();
    }
    void Shoot(Minion target)
    {
        Projectile proj = GameObject.Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Projectile>();
        (float, Vector2)? impactPrediction = PredictImpact(target);
        if (impactPrediction.HasValue) 
        {
            GameObject aimTarget = new GameObject();
            aimTarget.transform.position = impactPrediction.Value.Item2;
            float timeToImpact = impactPrediction.Value.Item1 / projectileSpeed;
            proj.ShootAt(aimTarget.transform, timeToImpact, projectileSpeed, damage);
            GameObject.Destroy(aimTarget);
            currentAmmo--;
            timeOfLastShot = Time.time;
            if (currentAmmo <= 0) isEmpty = true;
        }   
    }

    /// <summary>
    /// Predicts where the projectile will impact a moving minion
    /// </summary>
    /// <param name="target">The minion that you want to know the impact point of</param>
    /// <returns>
    /// A pair, where the first value is how far the predicted impact location is from the tower, and the second value is the impact location.
    /// Returns null if the tower cannot reach the minion within predictionSecondsLookAhead seconds, meaning the minion is too far away for the set projectile speed
    /// </returns>
    private (float, Vector2)? PredictImpact(Minion target)
    {
        List<(float, Vector2)> minionDistanceToPosition = target.DistanceLookAhead(transform.position, predictionSecondsLookAhead, predictionSamplesPerSecond);

        for (int i = 0; i < minionDistanceToPosition.Count; i++)
        {
            float timeInFlight = i / predictionSamplesPerSecond;
            float projectileDistance = timeInFlight * projectileSpeed;

            if (projectileDistance >= minionDistanceToPosition[i].Item1)
            {
                return minionDistanceToPosition[i];
            }
        }
        return null;
    }

    public bool Reload(int playerTotalResources)
    {
        if (playerTotalResources >= costToReload)
        {
            currentAmmo = maxAmmo;
            isEmpty = false;
            return true;
        } else {
            return false;
        }

    }
}
