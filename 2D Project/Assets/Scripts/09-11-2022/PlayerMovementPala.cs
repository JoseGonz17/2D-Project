using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementPala : MonoBehaviour
{
    private Rigidbody2D objectToMove;

    public float movementSpeed;

    private float movementDirection;

    private void Start()
    {
        objectToMove = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movementDirection = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()

    {
        objectToMove.velocity = new Vector3(0, movementDirection * movementSpeed, 0);
    }
}