using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorCollision : MonoBehaviour
{
    public string predator;

    // limit number of clones
    //private GameObject[] totalPrefabs;
    //int count;

    void Start()
    {
        //set limit to number of game object clones
        //totalPrefabs = GameObject.FindGameObjectsWithTag(predator);
        //count = totalPrefabs.Length;
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
        //set limit to number of game object clones
        //if (count >= 500)
        //{
        //    Destroy(gameObject);
        //}

        //if (gameObject.transform.position.y <= 0)
        //{
        //    Destroy(gameObject);
        //}
    } 
   
}
