using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class playerNameInput : MonoBehaviour
{
    /*
    public InputField player1InputField;
    public InputField player2InputField;
    public Button startButton;

    void Start()
    {
        startButton.onClick.AddListener(OnStartButtonClicked);
    }

    void OnStartButtonClicked()
    {
        string player1Name = player1InputField.text;
        string player2Name = player2InputField.text;

        if (!string.IsNullOrEmpty(player1Name) && !string.IsNullOrEmpty(player2Name))
        {
            PlayerPrefs.SetString("Player1Name", player1Name);
            PlayerPrefs.SetString("Player2Name", player2Name);
            PlayerPrefs.Save();

            // Hide the input fields and start button after input is done
            player1InputField.gameObject.SetActive(false);
            player2InputField.gameObject.SetActive(false);
            startButton.gameObject.SetActive(false);

            // Start the game (enable ball movement, etc.)
            GameObject ball = GameObject.FindWithTag("Ball");
            if (ball != null)
            {
                ball.GetComponent<ballMovement>().LaunchBall();
            }
        }
    }
    */

    //------------------------------------------------------------------------------------------------------------------------------------------

    /*
    public InputField player1InputField;
    public InputField player2InputField;
    public Button startButton;

    void Start()
    {
        startButton.onClick.AddListener(OnStartButtonClicked);
    }

    void OnStartButtonClicked()
    {
        string player1Name = player1InputField.text;
        string player2Name = player2InputField.text;

        if (!string.IsNullOrEmpty(player1Name) && !string.IsNullOrEmpty(player2Name))
        {
            PlayerPrefs.SetString("Player1Name", player1Name);
            PlayerPrefs.SetString("Player2Name", player2Name);
            PlayerPrefs.Save();

            // Transition to the 2 PLAYERS scene
            SceneManager.LoadScene("2 PLAYERS");
        }
    }
    */

    //------------------------------------------------------------------------------------------------------------------------------------------
    /*
    public InputField player1InputField;
    public InputField player2InputField;
    public Button startButton;

    void Start()
    {
        startButton.onClick.AddListener(OnStartButtonClicked);
    }

    void OnStartButtonClicked()
    {
        string player1Name = player1InputField.text;
        string player2Name = player2InputField.text;

        if (!string.IsNullOrEmpty(player1Name) && !string.IsNullOrEmpty(player2Name))
        {
            PlayerPrefs.SetString("Player1Name", player1Name);
            PlayerPrefs.SetString("Player2Name", player2Name);
            PlayerPrefs.Save();

            // Transition to the '2-PLAYERS[MULTIPLAYER] SCENE'
            SceneManager.LoadScene("2 PLAYERS");
        }
    }
    */
    //------------------------------------------------------------------------------------------------------------------------------------------
    public TMP_InputField player1InputField;
    public TMP_InputField player2InputField;
    public Button startButton;

    void Start()
    {
        Debug.Log("PlayerNameInput script started.");
        startButton.onClick.AddListener(OnStartButtonClicked);
    }

    void OnStartButtonClicked()
    {
        Debug.Log("Start button clicked.");
        string player1Name = player1InputField.text;
        string player2Name = player2InputField.text;

        Debug.Log($"Player 1 Name: {player1Name}");
        Debug.Log($"Player 2 Name: {player2Name}");

        if (!string.IsNullOrEmpty(player1Name) && !string.IsNullOrEmpty(player2Name))
        {
            PlayerPrefs.SetString("Player1Name", player1Name);
            PlayerPrefs.SetString("Player2Name", player2Name);
            PlayerPrefs.Save();

            Debug.Log("Player names saved. Attempting to load '2 PLAYERS' scene.");
            SceneManager.LoadScene("2 PLAYERS");
        }
        else
        {
            Debug.LogWarning("Player names are not filled out correctly.");
        }
    }
}

