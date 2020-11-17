using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGameMenu : MonoBehaviour
{
    public GameObject pauseGMenu;
    public bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        pauseGMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
                AudioListener.volume = 1f;
            }
            else
            {
                PauseTheGame();
                AudioListener.volume = 0f;
            }

        }
    }

    public void PauseTheGame()
    {
        pauseGMenu.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.volume = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseGMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        AudioListener.volume = 1f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("L1 SandBox");
        AudioListener.volume = 1f;
    }

    public void BackMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        AudioListener.volume = 1f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
