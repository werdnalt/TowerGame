using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MinionSpawner : MonoBehaviour
{
    public Path path;
    public float timeBetweenSpawns;
    public GameObject minion;

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
        if (Time.time - timeOfLastMinionSpawn >= timeBetweenSpawns) Spawn();
    }

    void Spawn()
    {
        timeOfLastMinionSpawn = Time.time;
        Minion m = GameObject.Instantiate(minion, path.waypoints[0].transform.position, Quaternion.identity).GetComponent<Minion>();
        m.SetPath(path); // set minion to begin walking path
    }
}
