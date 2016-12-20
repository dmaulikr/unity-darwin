using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorCollision : MonoBehaviour
{

    public string predator;
    
    // public GameObject mate;

    void Awake ()
    {
      
    }

  
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == predator)
            Destroy(gameObject);

        //if (collision.gameObject == mate)


    }

  
}
