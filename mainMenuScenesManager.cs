using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuScenesManager : MonoBehaviour
{
    public void LoadSinglePlayerScene()
    {
        SceneManager.LoadScene("singlePlayerNameInputScene");
    }

    public void LoadMultiplayerScene()
    {
        SceneManager.LoadScene("NameInputScene");
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("Main Menu[GAME START SCENE]");
    }

    public void LoadInstructionsPage()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void QuitGame()
    {
        Debug.Log("QUITTING APPLICATION!");
        Application.Quit();
    }
}
