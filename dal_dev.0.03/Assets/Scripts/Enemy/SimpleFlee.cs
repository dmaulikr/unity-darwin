using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFlee : MonoBehaviour {

float amount;
public GameObject player;
Vector3 direction;

float speed;

void Start()
{
 
}

void Update()
{
    amount = ((player.transform.position) - (transform.position)).magnitude;
    direction = ((player.transform.position) - (transform.position)).normalized;

    if (amount < 20)
    { // player is less then 20 
        chased(); // animal flees
    }
    else
    { // normal
            direction = ((player.transform.position) - (transform.position)).normalized;
    }
}


void chased()
{
    transform.LookAt(new Vector3(player.transform.position.x, 0, player.transform.position.z));
    transform.position += -direction * speed * Time.deltaTime;
}

}