using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCharacter : MonoBehaviour
{
    private bool mousePressed = false;
    
    void Update ()
    {
        mousePressed = Input.GetMouseButtonDown(0);
        StartGame();
    }

    private void StartGame()
    {
        if (mousePressed)
        {
            Debug.Log("Pressed left click.");
            SceneManager.LoadScene("PetriDish", LoadSceneMode.Single);  
        }
    }
}
