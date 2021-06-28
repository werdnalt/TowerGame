using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MinionSpawner : MonoBehaviour
{
    public Path path;
    public Path.Direction pathTraversalDirection;
    public float timeBetweenGroupSpawns = 6f;
    public GameObject minion;
    public int groupSize = 5;
    private float timeOfLastGroupSpawn;
    private float timeBetweenMinionSpawns = 0.5f;
    private int minionsOfGroupSpawned = 0;
    private float timeOfLastMinionSpawn;


    // Start is called before the first frame update
    void Start()
    {
        if (!path)
        {
            Exception e = new Exception("Path missing in minion spawner");
            throw e;
        }

        timeOfLastMinionSpawn = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timeOfLastGroupSpawn >= timeBetweenGroupSpawns && Time.time - timeOfLastMinionSpawn >= timeBetweenMinionSpawns) Spawn();
    }

    private Vector3 SpawnPosition()
    {
        switch (pathTraversalDirection)
        {
            case Path.Direction.Forward:
                return new Vector3(path.waypoints[0].transform.position.x, path.waypoints[0].transform.position.y, -5f);
            case Path.Direction.Backward:
                return new Vector3(path.waypoints[path.waypoints.Count - 1].transform.position.x, path.waypoints[path.waypoints.Count - 1].transform.position.y, -5f);
            default:
                return Vector3.zero;
        }
    }

    void Spawn()
    {
        timeOfLastMinionSpawn = Time.time;
        Vector3 spawnPosition = SpawnPosition(); 
        Minion m = GameObject.Instantiate(minion, spawnPosition, Quaternion.identity).GetComponent<Minion>();
        m.SetPath(path, pathTraversalDirection); // set minion to begin walking path
        minionsOfGroupSpawned++;

        if (minionsOfGroupSpawned == groupSize)
        {
            timeOfLastGroupSpawn = Time.time;
            minionsOfGroupSpawned = 0;
        }
    }
}
