using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPrey : MonoBehaviour
{

    public Transform target;
    public Transform myTransform;
    public GameObject prey;

    void Update()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == prey)
            Destroy(collision.gameObject);
    }
}
