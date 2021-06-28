using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion : MonoBehaviour
{
    public int health = 3;
    public float speed;
    public float attackCooldown;
    public float attackDamage;

    private int targetWaypointIndex;
    private Path path;
    private bool isPaused;

    // Update is called once per frame
    void FixedUpdate()
    {
        // move toward waypoint
        if (path && targetWaypointIndex < path.waypoints.Count && !isPaused) Move();
    }

    void Move()
    {
        float step = speed * Time.fixedDeltaTime;
        transform.position = Vector2.MoveTowards(transform.position, path.waypoints[targetWaypointIndex].transform.position, step);
    }

    public void SetPath(Path p)
    {
        path = p;
        targetWaypointIndex = 1;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Waypoint>())
        {
            targetWaypointIndex++;
        }

        if (other.gameObject.GetComponent<Projectile>())
        {
            Debug.Log("KABOOM");
            Destroy(other.gameObject);
            TakeDamage(other.gameObject.GetComponent<Projectile>().damage);
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // collide with same team hero

        // collide with enemy (hero or minion)

        // collide with minion
        if (other.gameObject.GetComponent<Minion>()) isPaused = true;

    }

    void OnCollisionExit2D(Collision2D other)
    {
        isPaused = false;
    }

    void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0) Destroy(this.gameObject);
    }
}
