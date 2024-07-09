using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class scoreManager : MonoBehaviour
{
    /*
    public TextMeshProUGUI leftPlayerScoreText;
    public TextMeshProUGUI rightPlayerScoreText;
    public int winningScore = 10; // Score needed to win the game
    private int leftPlayerScore = 0;
    private int rightPlayerScore = 0;
    private bool gameEnded = false;

    // Method to update the score
    public void AddScore(string goalTag)
    {
        if (gameEnded) return;

        if (goalTag == "RightGoal")
        {
            leftPlayerScore++;
            leftPlayerScoreText.text = leftPlayerScore.ToString();

            if (leftPlayerScore >= winningScore)
            {
                string player1Name = PlayerPrefs.GetString("Player1Name", "Player 1");
                EndGame($"{player1Name} Wins!");
            }
        }
        else if (goalTag == "LeftGoal")
        {
            rightPlayerScore++;
            rightPlayerScoreText.text = rightPlayerScore.ToString();

            if (rightPlayerScore >= winningScore)
            {
                string player2Name = PlayerPrefs.GetString("Player2Name", "Player 2");
                EndGame($"{player2Name} Wins!");
            }
        }
    }

    // Method to reset the ball with a delay
    public void ResetBall(GameObject ball, float delayInSeconds)
    {
        StartCoroutine(ResetBallAfterDelay(ball, delayInSeconds));
    }

    private IEnumerator ResetBallAfterDelay(GameObject ball, float delayInSeconds)
    {
        yield return new WaitForSeconds(delayInSeconds);
        ball.transform.position = Vector2.zero;
        ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        if (!gameEnded)
        {
            ball.SetActive(true);
            ball.GetComponent<ballMovement>().LaunchBall();
        }
    }

    private void EndGame(string message)
    {
        gameEnded = true;
        // Store the winning message using PlayerPrefs
        PlayerPrefs.SetString("WinningMessage", message);
        // Load the winning screen scene
        SceneManager.LoadScene("WinningScreen");
    }
    */

    //------------------------------------------------------------------------------------------------------------------------------------------
    /*
    public TextMeshProUGUI leftPlayerScoreText;
    public TextMeshProUGUI rightPlayerScoreText;
    public int winningScore = 10; // Score needed to win the game
    private int leftPlayerScore = 0;
    private int rightPlayerScore = 0;
    private bool gameEnded = false;

    // Method to update the score
    public void AddScore(string goalTag)
    {
        if (gameEnded) return;

        if (goalTag == "RightGoal")
        {
            leftPlayerScore++;
            leftPlayerScoreText.text = leftPlayerScore.ToString();

            if (leftPlayerScore >= winningScore)
            {
                string player1Name = PlayerPrefs.GetString("Player1Name", "Player 1");
                EndGame($"{player1Name} Wins!");
            }
        }
        else if (goalTag == "LeftGoal")
        {
            rightPlayerScore++;
            rightPlayerScoreText.text = rightPlayerScore.ToString();

            if (rightPlayerScore >= winningScore)
            {
                string player2Name = PlayerPrefs.GetString("Player2Name", "Player 2");
                EndGame($"{player2Name} Wins!");
            }
        }
    }

    // Method to reset the ball with a delay
    public void ResetBall(GameObject ball, float delayInSeconds)
    {
        StartCoroutine(ResetBallAfterDelay(ball, delayInSeconds));
    }

    private IEnumerator ResetBallAfterDelay(GameObject ball, float delayInSeconds)
    {
        yield return new WaitForSeconds(delayInSeconds);
        ball.transform.position = Vector2.zero;
        ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        if (!gameEnded)
        {
            ball.SetActive(true);
            ball.GetComponent<ballMovement>().LaunchBall();
        }
    }

    private void EndGame(string message)
    {
        gameEnded = true;
        // Store the winning message using PlayerPrefs
        PlayerPrefs.SetString("WinningMessage", message);
        // Load the winning screen scene
        SceneManager.LoadScene("WinningScreen");
    }
    */
    //------------------------------------------------------------------------------------------------------------------------------------------

    public TextMeshProUGUI leftPlayerScoreText;
    public TextMeshProUGUI rightPlayerScoreText;
    public int winningScore = 10; // Score needed to win the game
    private int leftPlayerScore = 0;
    private int rightPlayerScore = 0;
    private bool gameEnded = false;

    private bool isSinglePlayerMode;

    void Start()
    {
        // Determine if we are in single-player mode
        isSinglePlayerMode = SceneManager.GetActiveScene().name == "SinglePlayer[AI]";
    }

    // Method to update the score
    public void AddScore(string goalTag)
    {
        if (gameEnded) return;

        if (goalTag == "RightGoal")
        {
            leftPlayerScore++;
            leftPlayerScoreText.text = leftPlayerScore.ToString();

            if (leftPlayerScore >= winningScore)
            {
                string player1Name = isSinglePlayerMode ? PlayerPrefs.GetString("SinglePlayerName", "Player") : PlayerPrefs.GetString("Player1Name", "Player 1");
                EndGame($"{player1Name} Wins!");
            }
        }
        else if (goalTag == "LeftGoal")
        {
            rightPlayerScore++;
            rightPlayerScoreText.text = rightPlayerScore.ToString();

            if (rightPlayerScore >= winningScore)
            {
                string player2Name = isSinglePlayerMode ? "AI" : PlayerPrefs.GetString("Player2Name", "Player 2");
                EndGame($"{player2Name} Wins!");
            }
        }
    }

    // Method to reset the ball with a delay
    public void ResetBall(GameObject ball, float delayInSeconds)
    {
        StartCoroutine(ResetBallAfterDelay(ball, delayInSeconds));
    }

    private IEnumerator ResetBallAfterDelay(GameObject ball, float delayInSeconds)
    {
        yield return new WaitForSeconds(delayInSeconds);
        ball.transform.position = Vector2.zero;
        ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        if (!gameEnded)
        {
            ball.SetActive(true);
            ball.GetComponent<ballMovement>().LaunchBall();
        }
    }

    private void EndGame(string message)
    {
        gameEnded = true;
        // Store the winning message using PlayerPrefs
        PlayerPrefs.SetString("WinningMessage", message);
        // Load the unified winning screen scene
        SceneManager.LoadScene("WinningScreen");
    }

}
