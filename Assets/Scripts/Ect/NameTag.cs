using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameTag : MonoBehaviour
{
    public TMP_Text nameText;

    private void Start()
    {
        string playerName = GameManager.Instance.PlayerName;
        nameText.text = playerName;
    }
}