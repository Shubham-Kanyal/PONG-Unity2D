using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class singlePlayerScoreManager : MonoBehaviour
{
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI aiScoreText;
    public int winningScore = 10; // Score needed to win the game
    private int playerScore = 0;
    private int aiScore = 0;
    private bool gameEnded = false;

    // Method to update the score
    public void AddScore(string goalTag)
    {
        if (gameEnded) return;

        if (goalTag == "RightGoal")
        {
            playerScore++;
            playerScoreText.text = playerScore.ToString();

            if (playerScore >= winningScore)
            {
                string playerName = PlayerPrefs.GetString("SinglePlayerName", "Player");
                EndGame($"{playerName} Wins!");
            }
        }
        else if (goalTag == "LeftGoal")
        {
            aiScore++;
            aiScoreText.text = aiScore.ToString();

            if (aiScore >= winningScore)
            {
                EndGame("AI Wins!");
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
        PlayerPrefs.SetString("SinglePlayerWinningMessage", message);
        // Load the single player winning screen scene
        SceneManager.LoadScene("singlePlayerWinningScreen");
    }
}
