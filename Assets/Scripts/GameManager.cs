using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager: MonoBehaviour
{
    public GameObject edgeCollider;
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        PlaceScreenEdgeColliders();
    }

    void PlaceScreenEdgeColliders()
    {
        float colliderThickness = 1;

        // Edges of screen space translated to world space
        Vector2 top = camera.ScreenToWorldPoint(new Vector3(camera.pixelWidth / 2f, camera.pixelHeight, 0));
        Vector2 right = camera.ScreenToWorldPoint(new Vector3(camera.pixelWidth, camera.pixelHeight / 2f, 0));
        Vector2 bottom = camera.ScreenToWorldPoint(new Vector3(camera.pixelWidth / 2f, 0, 0));
        Vector2 left = camera.ScreenToWorldPoint(new Vector3(0, camera.pixelHeight / 2f, 0));

        // We want the edge of the collider to align with the edge of the screen. Therefore, we have to offset the collider by half of it's width, to account for the fact
        // that the origin is at the center (similar to the way extents works)
        left.x -= colliderThickness / 2f;
        right.x += colliderThickness / 2f;
        top.y += colliderThickness / 2f;
        bottom.y -= colliderThickness / 2f;

        GameObject screenLeftCollider = GameObject.Instantiate(edgeCollider, left, Quaternion.identity);
        GameObject screenRightCollider = GameObject.Instantiate(edgeCollider, right, Quaternion.identity);
        GameObject screenTopCollider = GameObject.Instantiate(edgeCollider, bottom, Quaternion.identity);
        GameObject screenBottomCollider = GameObject.Instantiate(edgeCollider, top, Quaternion.identity);

        BoxCollider2D leftBoxCollider = screenLeftCollider.GetComponent<BoxCollider2D>();
        leftBoxCollider.size = new Vector2(colliderThickness, top.y - bottom.y);

        BoxCollider2D rightBoxCollider = screenRightCollider.GetComponent<BoxCollider2D>();
        rightBoxCollider.size = new Vector2(colliderThickness, top.y - bottom.y);

        BoxCollider2D topBoxCollider = screenTopCollider.GetComponent<BoxCollider2D>();
        topBoxCollider.size = new Vector2(right.x - left.x, colliderThickness);

        BoxCollider2D bottomBoxCollider = screenBottomCollider.GetComponent<BoxCollider2D>();
        bottomBoxCollider.size = new Vector2(right.x - left.x, colliderThickness);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
