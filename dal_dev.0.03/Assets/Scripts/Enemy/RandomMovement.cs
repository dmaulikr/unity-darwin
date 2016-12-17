using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class RandomMovement : MonoBehaviour {

    public float timer;

    public int newtarget;

    public float speed;

    public NavMeshAgent nav;

    public Vector3 Target;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        nav = gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= newtarget)
        {
            newTarget();
            timer = 0;
        }
    }

    void newTarget()
    {
        float myX = gameObject.transform.position.x;
        float myZ = gameObject.transform.position.z;

        float xPos = myX + Random.Range(myX - 20, myX + 20);
        float zPos = myZ + Random.Range(myZ - 20, myZ+ 20);

        Target = new Vector3(xPos, gameObject.transform.position.y, zPos);

        nav.SetDestination(Target);  
    }
}
