using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCharacter : MonoBehaviour
{

    string passValue;

    void OnMouseOver()
    {
        Debug.Log("hovering object");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed left click.");

            Object.DontDestroyOnLoad(this.gameObject);
            StartGame();

            // one of three selections for character choice (forth selection to watch and not play)
            // selection stored in string
            // string will not be destryoed by using: DontDestroyOnLoad()
            // new scene is loaded with all 4 player game objects not active
            // new scene activates player object attached to string
            // for example: if(passValue == "Carnivore"){setActive(GameObject.PlayerCarnivore)
            // 

        }
    }

    


    private void StartGame()
    {

        SceneManager.LoadScene("PetriDish", LoadSceneMode.Single);


        // choose character and load scene
        /**
         * TODO:
         * if (mouseclick == gameobject carn)
         * load scene
         * select carn
         *  
         * if (mouseclick == gameobject herb)
         * load scene
         * select herb      
         *    
         * if (mouseclick == gameobject bact)
         * load scene
         * select bact
         * 
         */
    }
}
