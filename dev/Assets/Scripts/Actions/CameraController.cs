﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
 
    private Vector3 offset;

    void Start()
    {
        player = GameObject.FindWithTag("Player");

        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;  
    }
}
