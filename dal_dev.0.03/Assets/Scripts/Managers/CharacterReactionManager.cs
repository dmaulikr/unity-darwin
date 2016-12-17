using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *  v0.06 npc characters react to each other
 *      v0.06.1 npc chases other npc
 *      v0.06.2 npc flees from other npc
 *      v0.06.3 chase/flee defined: carn > herb > plant > water > bacteria > carn
 *      v0.06.4 npc of same type are attracted to each other* 
 **/


public class CharacterReactionManager : MonoBehaviour {

    UnityEngine.AI.NavMeshAgent nav;
    Transform locatePrey;
    public string prey;
    //public GameObject prey;

    void Awake()
    {
        locatePrey = GameObject.FindGameObjectWithTag (prey).transform;
        //playerHealth = player.GetComponent <PlayerHealth> ();
        //enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
    }

    // Use this for initialization
	void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        nav.SetDestination(locatePrey.position);
    }
}
