using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour {

    GameObject target;
    public float speed;
    private Rigidbody rb;
    public string targetObject;
    public int range;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        target = GameObject.FindWithTag(targetObject);

        Vector3 targetLocation = GetComponent<Rigidbody>().position;
        Vector3 enemyLocation = target.transform.position;

        

        if (Vector3.Distance(enemyLocation, targetLocation) < range)
        {
            InRange();
        }

    }

    void InRange()
    {
        float posX = target.transform.position.x;
        float posZ = target.transform.position.z;
        Vector3 movement = new Vector3(posX, 0.5f, posZ - 7.70f);
        rb.AddForce(movement * speed);
    }

}