using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseCharacter : MonoBehaviour
{
    public GameObject[] PossibleCharacters;
    public int SelectedCharacterIndex;
    Vector3 startLocation = new Vector3(0f, 0.5f, 0f);

    [HideInInspector]
    public GameObject playerCharacter;

    public int index;
    private Button btn;

    void Start()
    {
        //if (btn.onClick)
        //    btn = GetComponent<Button>();
        //btn.onClick.AddListener(() => actionToMaterial(index));

        //playerCharacter = Instantiate(PossibleCharacters[SelectedCharacterIndex], startLocation, Quaternion.identity);
    }





    void actionToMaterial(int idx)
    {
        Debug.Log("change material to HIT  on material :  " + idx);
    }
}