using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeFormManager : MonoBehaviour {

  
    public GameObject lifeForm; // The enemy prefab to be spawned.
    public float firstSpawn = 0f;
    public float spawnTime = 10f;            // How long between each spawn.
    public Transform[] spawnNests;         // An array of the spawn points this enemy can spawn from.

    //public GameObject prey;
   // public GameObject mate;



    // Use this for initialization
    void Start () {
        InvokeRepeating("Spawn", firstSpawn, spawnTime);
    }
	
	// Update is called once per frame
	void Update () {
        if (lifeForm.transform.position.y <= 0)
        {
            Destroy(lifeForm);
        }

    }

    void Spawn()
    {

        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnNests.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(lifeForm, spawnNests[spawnPointIndex].position, spawnNests[spawnPointIndex].rotation);
    }

   
}
