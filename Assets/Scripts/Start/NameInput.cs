using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public TMP_InputField playerNameInput;
    public Button startButton;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            InputName();
        }
    }

    public void InputName()
    {
        string playerName = playerNameInput.text;

        startButton.interactable = playerName.Length > 1 && playerName.Length < 11;

        if (playerName.Length > 1 && playerName.Length < 11)
        {
            GameManager.Instance.PlayerName = playerName;
        }
    }
}