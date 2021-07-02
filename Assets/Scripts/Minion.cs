using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion : MonoBehaviour
{
    public float health = 3;
    public float speed;
    public float attackSpeed;
    public float attackDamage;
    public int owner;

    private int targetWaypointIndex;
    private Path path;
    private Path.Direction pathTraversalDirection;
    private bool isPaused;
    private Minion attackTarget;
    private float lastAttackTime = -float.MaxValue;

    // Update is called once per frame
    void FixedUpdate()
    {
        // move toward waypoint
        if (path && targetWaypointIndex < path.waypoints.Count && !isPaused) Move();
    }

    private void Update()
    {
        if (attackTarget && Time.time - lastAttackTime > attackSpeed)
        {
            Attack();
        }
    }

    void Move()
    {
        float step = speed * Time.fixedDeltaTime;
        transform.position = Vector2.MoveTowards(transform.position, path.waypoints[targetWaypointIndex].transform.position, step);

        targetWaypointIndex = UpdateTargetWaypoint(transform.position, targetWaypointIndex);
    }

    /// <summary>
    /// The goal of this method is to predict where the minion will be located along a given path at some point in the future, relative to a reference point. It accomplishes this by
    /// moving a test point along the path and creating data points of the location and distance from the reference point at a given sample interval.
    /// </summary>
    /// <param name="fromPoint">The reference point that you want to predict this minion's distance from</param>
    /// <param name="secondsLookAhead">The amount of seconds into the future you want to predict for</param>
    /// <param name="samplesPerSecond">The amount of data points that you want to collect per second of prediction</param>
    /// <returns>A list of pairs, where the first value is the distance from the reference point, and the second value is the predicted position in world space</returns>
    public List<(float, Vector2)> DistanceLookAhead(Vector2 fromPoint, float secondsLookAhead, float samplesPerSecond)
    {
        List<(float, Vector2)> distances = new List<(float, Vector2)>();
        Vector2 lookaheadMarker = transform.position;
        int lookaheadWaypointIndex = this.targetWaypointIndex;
        for(int i = 0; i <= secondsLookAhead * samplesPerSecond; i++)
        {
            distances.Add((Vector2.Distance(fromPoint, lookaheadMarker), lookaheadMarker));

            if (!isPaused)
            {
                lookaheadMarker = Vector2.MoveTowards(lookaheadMarker, path.waypoints[lookaheadWaypointIndex].transform.position, speed / samplesPerSecond);
                lookaheadWaypointIndex = UpdateTargetWaypoint(lookaheadMarker, lookaheadWaypointIndex);
            }
        }
        return distances;
    }

    public void SetPath(Path p, Path.Direction pathTraversalDirection, int owner)
    {
        path = p;
        this.pathTraversalDirection = pathTraversalDirection;
        this.owner = owner;

        switch (pathTraversalDirection)
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Minion minion = collision.gameObject.GetComponent<Minion>();
        if (minion)
        {
            isPaused = true;
            if (minion.owner != owner)
            {
                attackTarget = minion;
            }
        }

        Projectile projectile = collision.gameObject.GetComponent<Projectile>();
        if (projectile)
        {
            TakeDamage(projectile.damage);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Minion minion = collision.gameObject.GetComponent<Minion>();
        if (minion)
        {
            isPaused = false;
        }
    }

    void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0) Destroy(this.gameObject);
    }

    private int UpdateTargetWaypoint(Vector2 position, int targetWaypointIndex)
    {
        if (Vector2.Distance(position, path.waypoints[targetWaypointIndex].transform.position) < 0.01f)
        {
            Debug.Log("hit waypoint");
            switch (pathTraversalDirection)
            {
                case Path.Direction.Forward:
                    return targetWaypointIndex + 1;
                case Path.Direction.Backward:
                    return targetWaypointIndex - 1;
            }
        }

        return targetWaypointIndex;
    }

    private void Attack()
    {
        attackTarget.TakeDamage(attackDamage);
        lastAttackTime = Time.time;
    }
}
