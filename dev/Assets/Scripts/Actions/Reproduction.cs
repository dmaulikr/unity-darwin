using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproduction : MonoBehaviour
{
    public float timeUntilBirth = 10.0f;
    float timer;
    public string mate;
    public GameObject newBorn;
    public Vector3 babyNest;
    bool mateInRange;

    private GameObject[] totalPrefabs;
    int count;

    void Start()
    {
        totalPrefabs = GameObject.FindGameObjectsWithTag(mate);
        count = totalPrefabs.Length;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == mate)
        {
            mateInRange = true;
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

        if (timer >= timeUntilBirth && mateInRange)
        {
            BabyBorn();
        }

        if (count >= 50)
        {
            Destroy(gameObject);
        }

        if (gameObject.transform.position.y <= 0)
        {
            Destroy(gameObject);
        }
    }

    void BabyBorn()
    {

        Instantiate(newBorn, babyNest, Quaternion.identity);
    }
}