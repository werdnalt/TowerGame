using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;

    Vector2 movement;
    Rigidbody2D rbody;

    void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.freezeRotation = true;
    }

    void FixedUpdate()
    {
        Movement();
    }

    void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    void Movement()
    {
        Vector2 currentPos = rbody.position;
 
        Vector2 adjustedMovement = movement * movementSpeed;
 
        Vector2 newPos = currentPos + adjustedMovement * Time.fixedDeltaTime;
 
        rbody.MovePosition(newPos);
    }

}
