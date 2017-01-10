using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    //public GameObject playerSelect1;
    //public GameObject playerSelect2;
    //public GameObject playerSelect3;
    GameObject player;
    

    private Vector3 offset;

    void Start()
    {
        player = GameObject.FindWithTag("Player");

        offset = transform.position - player.transform.position;
        //if (playerSelect1 != null)
        //{
        //    offset = transform.position - playerSelect1.transform.position;
        //}

        //else if (playerSelect2 != null)
        //{
        //    offset = transform.position - playerSelect2.transform.position;
        //}

        //else if (playerSelect3 != null)
        //{
        //    offset = transform.position - playerSelect3.transform.position;
        //}

        //else
        //{
        //    Debug.Log("no player was loaded in Start function");
        //}

    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        //if (playerSelect1 != null)
        //{
        //    transform.position = playerSelect1.transform.position + offset;
        //}

        //else if (playerSelect2 != null)
        //{
        //    transform.position = playerSelect2.transform.position + offset;
        //}

        //else if (playerSelect3 != null)
        //{
        //    transform.position = playerSelect3.transform.position + offset;
        //}

        //else
        //{
        //    Debug.Log("no player was loaded in LastUpdate() function");
        //}
    }
}
