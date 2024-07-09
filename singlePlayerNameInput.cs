using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class singlePlayerNameInput : MonoBehaviour
{
    public TMP_InputField playerNameInputField;

    public void OnStartGameButtonClicked()
    {
        string playerName = playerNameInputField.text;
        PlayerPrefs.SetString("SinglePlayerName", playerName);
        SceneManager.LoadScene("SinglePlayer[AI]");
    }
}
