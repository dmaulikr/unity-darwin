﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        //rb.angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);
        rb.AddForce(movement * speed);
    }
}