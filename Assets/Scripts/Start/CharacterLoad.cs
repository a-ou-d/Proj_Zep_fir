using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLoad : MonoBehaviour
{
    public GameObject[] characterPrefabs;

    private void Start()
    {
        int chooseCharacterId = PlayerPrefs.GetInt("ChooseCharacter", 1);
        GameObject chooseCharacter = Instantiate(characterPrefabs[chooseCharacterId]);
        chooseCharacter.transform.position = Vector3.zero;
    }
}
