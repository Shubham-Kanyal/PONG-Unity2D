using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class winningScreenManager : MonoBehaviour
{
    public TextMeshProUGUI winningMessageText;

    void Start()
    {
        // Get the winning message from the GameManager or another persistent object
        string winningMessage = PlayerPrefs.GetString("WinningMessage", "No Winner");
        winningMessageText.text = winningMessage;
    }
}
