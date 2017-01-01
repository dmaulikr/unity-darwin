using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOrFollow : MonoBehaviour {

    public float timer;
    public int newRandomTarget;
    public float speed;
    public Vector3 randomTarget;

    GameObject followTarget;
    private Rigidbody rb;
    public string targetObject;
    public int range;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        followTarget = GameObject.FindWithTag(targetObject);
        Vector3 targetLocation = GetComponent<Rigidbody>().position;
        Vector3 enemyLocation = followTarget.transform.position;

        if (timer >= newRandomTarget && Vector3.Distance(enemyLocation, targetLocation) > range)
        {
            NewRandomTarget();
            timer = 0;
            return;
        }

        if (Vector3.Distance(enemyLocation, targetLocation) < range)
        {
            InRange();
            timer = 0;
            return;
        }
    }

    void NewRandomTarget()
    {
        float myX = gameObject.transform.position.x;
        float myZ = gameObject.transform.position.z;
        float xPos = myX + Random.Range(myX - 50, myX + 50);
        float zPos = myZ + Random.Range(myZ - 50, myZ + 50);
        Vector3 randomTarget = new Vector3(xPos, gameObject.transform.position.y, zPos);
        rb.AddForce(randomTarget * speed);

        // speeding out of control
        string strRandom = "Random speed is: ";
        string speedStr = speed.ToString();
        string strFull = strRandom + speedStr;
        Debug.Log(strFull);
    }

    void InRange()
    {
        
        float posX = followTarget.transform.position.x;
        float posZ = followTarget.transform.position.z;
        Vector3 movement = new Vector3(posX, 0.5f, posZ);
        rb.AddForce(movement * speed);

        //speeding out of control
        string strRange = "InRange speed is: ";
        string speedStr = speed.ToString();
        string strFull = strRange + speedStr;
        Debug.Log(strFull);
    }
}