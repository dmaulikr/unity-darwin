using UnityEngine;
using System.Collections;

public class RandomMovement : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb;
    //private float randomHorizontal = Math.Random(0.1, 179.9);

    //Random randomMove = new Random();

    //Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
    //Instantiate(prefab, position, Quaternion.identity);

    private float ranHor = Random.Range(0.1f, 359.9f);
    private float ranVer = Random.Range(0.1f, 359.9f);

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //int randomNumber = randomMove.Next(0, 100);
        float moveHorizontal = Input.GetAxis("Horizontal"); //RANDOM HORIZONTAL
        float moveVertical = Input.GetAxis("Vertical"); // RANDOM VERTICAL

        Vector2 movement = new Vector2(ranHor, ranVer);

        rb.AddForce(movement * speed);
    }

    //public float movement;
    //void fixedupdate()
    //{
    //    other.rigidbody.addforce(vector3.up * movement, forcemode.acceleration);
    //}


}
