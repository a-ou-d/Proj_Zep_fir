using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TMP_StartButton : MonoBehaviour
{
    public void CharacterChoice()
    {
        SceneManager.LoadScene("ChoiceScene");
    }
}
