using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject projectile;
    public float timeBetweenShots;
    public float projectileSpeed;
    public float projectileLifetime;

    private Queue<GameObject> minionsToShoot = new Queue<GameObject>();
    private float timeOfLastShot;

    void Start()
    {
        timeOfLastShot = Time.time;
    }

    void Update()
    {
        if (Time.time - timeOfLastShot >= timeBetweenShots && minionsToShoot.Count > 0) Shoot();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Minion>()) minionsToShoot.Enqueue(other.gameObject);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Minion>()) minionsToShoot.Dequeue();
    }

    void Shoot()
    {
        Projectile proj = GameObject.Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Projectile>();
        if (proj) 
        {
            proj.ShootAt(minionsToShoot.Peek().transform, projectileLifetime, projectileSpeed);
            timeOfLastShot = Time.time;
        }   
    }
}
