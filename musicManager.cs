using UnityEngine;
using UnityEngine.SceneManagement;

public class musicManager : MonoBehaviour
{
    /*
    public AudioSource musicSource;
    public AudioClip gameOverClip;
    public static musicManager instance;

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

    void Start()
    {
        musicSource = GetComponent<AudioSource>();
        musicSource.volume = PlayerPrefs.GetFloat("MusicVolume", 0.5f); // Default volume to 0.5
        musicSource.loop = true;
        musicSource.Play();
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "WinningScreen")
        {
            musicSource.Stop();
            PlayGameOverSound();
        }
    }

    public void SetVolume(float volume)
    {
        musicSource.volume = volume;
        PlayerPrefs.SetFloat("MusicVolume", volume);
    }

    private void PlayGameOverSound()
    {
        AudioSource.PlayClipAtPoint(gameOverClip, Camera.main.transform.position);
    }
    */

    //------------------------------------------------------------------------------------------------------------------------------------------------------
    public AudioSource musicSource;
    public AudioClip gameMusic;
    public AudioClip gameOverClip;
    public static musicManager instance;

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

    void Start()
    {
        musicSource.volume = PlayerPrefs.GetFloat("MusicVolume", 0.5f); // Default volume to 0.5
        musicSource.loop = true;
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // List of scenes where the music should play
        string[] gameScenes = { "2 PLAYERS", "SinglePlayer[AI]" };

        if (scene.name == "WinningScreen")
        {
            musicSource.Stop();
            PlayGameOverSound();
        }
        else if (System.Array.Exists(gameScenes, s => s == scene.name))
        {
            // Only play music if it's not already playing
            if (!musicSource.isPlaying)
            {
                musicSource.clip = gameMusic;
                musicSource.Play();
            }
        }
        else
        {
            musicSource.Stop();
        }
    }

    public void SetVolume(float volume)
    {
        musicSource.volume = volume;
        PlayerPrefs.SetFloat("MusicVolume", volume);
    }

    private void PlayGameOverSound()
    {
        AudioSource.PlayClipAtPoint(gameOverClip, Camera.main.transform.position);
    }
}




