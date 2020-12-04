using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{

    public void ResOptions()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("ResOptions");
        AudioListener.volume = 1f;
    }


    public void Controls()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("ControlOptions");
        AudioListener.volume = 1f;
    }

    public void BackMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        AudioListener.volume = 1f;
    }

    public void BackOptions()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainOptions");
        AudioListener.volume = 1f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
