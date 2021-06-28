using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage;

    private Transform target;
    private bool hasTarget = false;
    private float projectileLifetime;
    private float projectileCreatedTime;
    private float projectileSpeed;

    private Vector3 aim;

    void Awake()
    {
        projectileCreatedTime = Time.time;
    }

    public void ShootAt(Transform target, float projectileLifetime, float projectileSpeed)
    {
        aim = (target.position - transform.position).normalized;
        this.target = target;
        this.projectileLifetime = projectileLifetime;
        this.projectileSpeed = projectileSpeed;
        hasTarget = true;
    }

    void Update()
    {
        if (hasTarget)
        {
            if (Time.time - projectileCreatedTime >= projectileLifetime) Destroy(this.gameObject);
            transform.position += aim * (projectileSpeed * Time.deltaTime);
        }
    }
}