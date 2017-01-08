using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorCollision : MonoBehaviour
{
    public string predator;

    void Start()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == predator)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {

    } 
   
}
