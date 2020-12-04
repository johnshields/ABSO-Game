using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuMP : MonoBehaviour
{

    public void Player1()
    {
        // reset bolts back to 0
        PlayerPrefs.SetInt("P1bolts", 0);

        // play the game
        SceneManager.LoadScene("P1_Splash Screen");
    }

    public void Player2()
    {
        // reset bolts back to 0
        PlayerPrefs.SetInt("P2bolts", 0);

        // play the game
        SceneManager.LoadScene("P2_Splash Screen");
    }

    public void BackMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        AudioListener.volume = 1f;
    }
 
    public void MPmenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MultiplayerMenu");
        AudioListener.volume = 1f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
