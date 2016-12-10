using UnityEngine;
using System.Collections;

public class RandomMovement : MonoBehaviour {


    public float movement;


    // Use this for initialization
    void Start () {
	
	}
	
    void FixedUpdate ()
    {
        other.rigidbody.AddForce(Vector3.up * movement, ForceMode.Acceleration);
    }

	// Update is called once per frame
	void Update ()
    {
        
    }
}
