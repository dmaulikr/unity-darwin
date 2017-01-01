using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour {

    Transform prey;               // Reference to the player's position.
    public string preyTag;
    //PlayerHealth playerHealth;      // Reference to the player's health.
    // EnemyHealth enemyHealth;        // Reference to this enemy's health.
    NavMeshAgent nav;               // Reference to the nav mesh agent.
    //Vector3 gameObjectPosition; location to test for out of bounds.

    void Awake()
    {
        // Set up the references.
        prey = GameObject.FindGameObjectWithTag(preyTag).transform;
        nav = GetComponent<NavMeshAgent>();
    }


    void Update()
    {

        // ... set the destination of the nav mesh agent to the player.
        if (prey != null)
            nav.SetDestination(prey.position);

        // destroy gameobject if out of bounds
        // if (GameObject.t)

    }
}
