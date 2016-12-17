//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//float distancePredator;
//float distancePrey;
////public GameObject player;
//public GameObject prey;
//public GameObject predator;

//Vector3 direction;
////Vector3 runPoint;
////Vector3 walkPoint;
//Vector3 flee;
//Vector3 chase;


//float speed;

//// 4 cases: 
////predator yes, prey no : flee
////predator yes prey yes : flee
////predator no prey yes : chase
////predator no prey no : normal

//void ReactionMovement()
//{
//    if ((predator no) && (prey no)) 
//    {
//        //normal return 1
//    } 
    
//    else (((predator yes) && (prey no)) || ((predator yes) && (prey yes))) 
//    {
//        //flee return 2
//    }

//    else ((predator no) && (prey yes)) 
//    {
//        //chase return 3
//    } 
//}

//int caseSwitch = 1;
//            switch (caseSwitch)
//            {
//                case 2:
//                    flee();;
//                    break;
//                case 3:
//                    chase();
//                    break;
//                default:
//                    moveRandom();
//                    break;
//            }

//void Start()
//{
//    runPoint = transform.position;
//    //walkPoint = transform.position;
//}

//void Update()
//{
//    distancePredator = ((player.transform.position) - (transform.position)).magnitude;
//    direction = ((player.transform.position) - (transform.position)).normalized;
//    if (amount > 100)
//    { // if player is more then 100 units away
//        normal(); // normal waypoint system or what you want
//    }
//    else if (amount > 20)
//    { // player is beetwen 20 and 100 units away
//        chased(); // animal has chased the player
//    }
//    else
//    { // player is less then 20 unity away
//        run();
//    }
//}

//void flee()
//{

//}

//void chase()
//{

//}

//void moveRandom()
//{

//}

//void normal()
//{
//    if ((walkPoint - transform.position).magnitude < 5)
//    {
//        // get new point here
//    }
//    else
//    {
//        // moving script here
//    }
//}

//void chased()
//{
//    transform.LookAt(new Vector3(player.transform.position.x, 0, player.transform.position.z));
//    transform.position += -direction * speed * Time.deltaTime;
//}

//void run()
//{
//    if ((runPoint - transform.position).magnitude < 5)
//    {

//    }
//    else
//    {
//        // moving script here
//    }
//}