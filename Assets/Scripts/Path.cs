using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public enum Direction
    {
        Forward,
        Backward
    }

    public List<GameObject> waypoints = new List<GameObject>();

    void Start()
    {
        Draw();
    }

    private void Draw()
    {
        if (waypoints.Count > 0)
        {
            GameObject pathLine = new GameObject();
            Vector3 firstWaypointPosition = waypoints.First().transform.position;
            pathLine.transform.position = new Vector3(firstWaypointPosition.x, firstWaypointPosition.y, 0.5f);
            pathLine.AddComponent<LineRenderer>();
            LineRenderer lr = pathLine.GetComponent<LineRenderer>();
            lr.material = new Material(Shader.Find("Specular"));
            lr.material.color = Color.red;
            Color pathColor = new Color(87 / 255f, 58 / 255f, 6 / 255f);
            lr.startColor = pathColor;
            lr.endColor = pathColor;
            lr.startWidth = 0.3f;
            lr.endWidth = 0.3f;
            lr.positionCount = waypoints.Count;

            for(int i = 0; i < waypoints.Count; i++)
            {
                Vector3 position = new Vector3(waypoints[i].transform.position.x, waypoints[i].transform.position.y, 0.5f);
                lr.SetPosition(i, position);
            }
        }
    }
}
