using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // delete previous game bolts
        PlayerPrefs.DeleteAll();

        // play the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ToSettings()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainSettings");
        AudioListener.volume = 1f;
    }

    public void BackMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        AudioListener.volume = 1f;
    }

    public void Multiplayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
