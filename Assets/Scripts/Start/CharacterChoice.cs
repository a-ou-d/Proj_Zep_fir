using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterChoice : MonoBehaviour
{
    public void OnCharacterClick(int characterId)
    {
        PlayerPrefs.SetInt("ChooseCharacter", characterId);
        SceneManager.LoadScene("MainScene");
    }
}
