using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviors : MonoBehaviour {

    public float timeUntilBirth = 10.0f;
    float timer;
    public string mate;
    public GameObject newBorn;
    public Vector3 babyNest;
    bool mateInRange;
    public string player;

    private GameObject[] totalPrefabs;
    int count;

    public string predator;

    void Start()
    {
        totalPrefabs = GameObject.FindGameObjectsWithTag(mate);
    }

 

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == mate)
        {
            mateInRange = true;

            if (gameObject.tag == "Carnivore")
            {
                Debug.Log("carnivore mate is in range");
            }
        }

        if (other.gameObject.tag == predator)
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == player)
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == mate)
        {
            mateInRange = false;
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        count = totalPrefabs.Length;

        if (timer >= timeUntilBirth && mateInRange)
        {
            BabyBorn();
        }

        if (count >= 50)
        {
            Destroy(gameObject);

            if (gameObject.tag == "Carnivore")
            {
                Debug.Log("carnivore more then 50");
            }           
        }

        if (gameObject.transform.position.y <= -0.5)
        {
            Destroy(gameObject);

            if (gameObject.tag == "Carnivore")
            {
                Debug.Log("carnivore less then 0.1");
            }
            
        }
    }

    void BabyBorn()
    {

        Instantiate(newBorn, babyNest, Quaternion.identity);
    }
}
