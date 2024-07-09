using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    /*
    public static sceneManager instance;
    public string player1Name;
    public string player2Name;
    public string winnerName;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("2 PLAYERS");        
    }

    public void EndGame(string winner)
    {
        winnerName = winner;
        SceneManager.LoadScene("2 PLAYERS");
    }
    */
    //------------------------------------------------------------------------------------------------------------------------------------------

    /*
    public static sceneManager instance;
    public string player1Name;
    public string player2Name;
    public string winnerName;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("2 PLAYERS");
    }

    public void EndGame(string winner)
    {
        winnerName = winner;
        SceneManager.LoadScene("WinningScreen");
    }
    */
    //------------------------------------------------------------------------------------------------------------------------------------------

    public static sceneManager instance;
    public string player1Name;
    public string player2Name;
    public string winnerName;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartMultiplayerGame()
    {
        SceneManager.LoadScene("2 PLAYERS");
    }

    public void StartSinglePlayerGame()
    {
        SceneManager.LoadScene("SinglePlayer[AI]");
    }

    public void EndGame(string winner)
    {
        winnerName = winner;
        SceneManager.LoadScene("WinningScreen");
    }
}
