using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject projectile;
    public float timeBetweenShots;
    public float projectileSpeed;
    public float projectileLifetime;
    public int maxAmmo;
    public int costToReload;
    public int damage;
    public bool isEmpty;

    private Queue<GameObject> minionsToShoot = new Queue<GameObject>();
    private float timeOfLastShot;
    private int currentAmmo;

    void Start()
    {
        timeOfLastShot = Time.time;
        currentAmmo = maxAmmo;
        isEmpty = false;
    }

    void Update()
    {
        if (Time.time - timeOfLastShot >= timeBetweenShots && minionsToShoot.Count > 0 && currentAmmo >= 1) Shoot(minionsToShoot.Peek().transform);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Minion>()) minionsToShoot.Enqueue(other.gameObject);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Minion>()) minionsToShoot.Dequeue();
    }
    void Shoot(Transform aimAt)
    {
        Projectile proj = GameObject.Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Projectile>();

        if (proj) 
        {
            proj.ShootAt(aimAt, projectileLifetime, projectileSpeed, damage);
            currentAmmo--;
            timeOfLastShot = Time.time;
            if (currentAmmo <= 0) isEmpty = true;
        }   
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
