/**
    * John Shields - G00348436
    * Main Menu Script
    * Buttons to other menus - Play game - Reset Bolts Score to 0
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // reset bolts back to 0
        PlayerPrefs.SetInt("bolts", 0);

        // play the game
         SceneManager.LoadScene("L1 Splash Screen");
    }

    public void ToSettings()
    {
        // to the options menu
        SceneManager.LoadScene("MainOptions");
        AudioListener.volume = 1f; // resume audio level
    }

    public void Multiplayer()
    {
        // to the multiplayer menu
        SceneManager.LoadScene("MultiplayerMenu");
    }

    public void BackMainMenu()
    {
        // to the menu menu
        SceneManager.LoadScene("MainMenu");
        AudioListener.volume = 1f;
    }

    public void MusicCredits()
    {
        // to the music credits
        SceneManager.LoadScene("MusicCredits");
        AudioListener.volume = 1f;
    }

    public void ExitGame()
    {
        // exit the game
        Application.Quit();
    }
}
