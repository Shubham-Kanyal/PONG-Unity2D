using UnityEngine;
using TMPro;

public class singlePlayerWinningScreen : MonoBehaviour
{
    public TextMeshProUGUI winningMessageText;

    void Start()
    {
        string winningMessage = PlayerPrefs.GetString("SinglePlayerWinningMessage", "No Winner");
        winningMessageText.text = winningMessage;
    }
}
