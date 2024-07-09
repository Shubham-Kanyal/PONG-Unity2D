using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;

public class singlePlayerWinningScript : MonoBehaviour
{
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI AIScoreText;

    [Header("WINNING SCORE[EDITABLE]")]
    public int winningScore = 10; // Score needed to win the game

    private int playerScore = 0;
    private int AIScore = 0;
    private bool gameEnded = false;

    void Update()
    {
        if (!gameEnded)
        {
            // Check scores
            // Update player and AI scores here based on game events
            // For example, when the player scores a point, increment playerScore
            // When the AI scores a point, increment AIScore
            // Update the corresponding UI text elements

            // Check if either the player or the AI reached the winning score
            if (playerScore >= winningScore)
            {
                //EndGame(PlayerPrefs.GetString("SinglePlayerName") + " Wins!");
                EndGame("Player Wins!");
            }
            else if (AIScore >= winningScore)
            {
                EndGame("AI Wins!");
            }
        }
    }

    private void EndGame(string message)
    {
        gameEnded = true;
        //Store the winning message using PlayerPrefs
        PlayerPrefs.SetString("WinningMessage", message);

        //Load the 'Winning Screen' scene
        SceneManager.LoadScene("singlePlayerWinningScreen");
    }

    public void AddScore(string goalTag)
    {
        if (gameEnded) return;

        if (goalTag == "LeftGoal")
        {
            playerScore++;
            playerScoreText.text = playerScore.ToString();
        }
        else if (goalTag == "RightGoal")
        {
            AIScore++;
            AIScoreText.text = AIScore.ToString();
        }
    }

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

}
