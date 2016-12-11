using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;

    

    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;
        playerHealth = player.GetComponent <PlayerHealth> ();
        enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
    }

    //void FreeRoam()
    //{
    //    {
    //        Vector2 randomDirection = Random.insideUnitSphere * roamRadius;
    //        randomDirection += transform.position;
    //        UnityEngine.AI.NavMeshHit hit;
    //        UnityEngine.AI.NavMesh.SamplePosition(randomDirection, out hit, roamRadius, 1);
    //        Vector2 finalPosition = hit.position;
    //        _nav.destination = finalPosition;
    //    }
    //}


    void Update ()
    {
        if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            nav.SetDestination (player.position);
        }
        else
        {
            nav.enabled = false;
        }
    }


}
