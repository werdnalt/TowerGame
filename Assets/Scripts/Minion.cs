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
    private Path.Direction pathTraversalDirection;
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

        if (Vector2.Distance(transform.position, path.waypoints[targetWaypointIndex].transform.position) < 0.01f)
        {
            Debug.Log("hit waypoint");
            switch (pathTraversalDirection)
            {
                case Path.Direction.Forward:
                    targetWaypointIndex++;
                    break;
                case Path.Direction.Backward:
                    targetWaypointIndex--;
                    break;
            }
        }
    }

    public void SetPath(Path p, Path.Direction pathTraversalDirection)
    {
        path = p;
        this.pathTraversalDirection = pathTraversalDirection;

        switch(pathTraversalDirection)
        {
            case Path.Direction.Forward:
                targetWaypointIndex = 1;
                break;
            case Path.Direction.Backward:
                targetWaypointIndex = path.waypoints.Count - 2;
                break;
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
