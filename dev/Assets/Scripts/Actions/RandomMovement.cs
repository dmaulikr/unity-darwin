using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class RandomMovement : MonoBehaviour {

    public float timer;
    public float timeLow;
    public float timeHigh;
    
    public NavMeshAgent nav;
    public Vector3 target;

    void Start()
    {
        nav = gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        nav.speed = 5;

        float newTarget = Random.Range(timeLow, timeHigh);
        timer += Time.deltaTime;
        if(timer >= newTarget)
        {
            NewTarget();
            timer = 0;
        }
    }

    void NewTarget()
    {
        //float myX = gameObject.transform.position.x;
        //float myZ = gameObject.transform.position.z;

        // float xPos = myX + Random.Range(myX - 100, myX + 100);
        // float zPos = myZ + Random.Range(myZ - 100, myZ+ 100);
        float xPos = Random.Range(-225, 225);
        float zPos = Random.Range(-225, 225);

        target = new Vector3(xPos, gameObject.transform.position.y, zPos);

        nav.SetDestination(target);  
    }
}
