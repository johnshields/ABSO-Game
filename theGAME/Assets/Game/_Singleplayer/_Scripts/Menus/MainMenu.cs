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
         
         // console output
         Debug.Log("Gameplay Started");
         Debug.Log("Player's Bolts have been reset");
    }

    public void ToSettings()
    {
        // to the options menu
        SceneManager.LoadScene("MainOptions");
        AudioListener.volume = 1f; // resume audio level
        Debug.Log("Load Options Menu");
    }

    public void Multiplayer()
    {
        // to the multiplayer menu
        SceneManager.LoadScene("MultiplayerMenu");
        Debug.Log("Load Multiplayer Menu");
    }

    public void BackMainMenu()
    {
        // to the menu menu
        SceneManager.LoadScene("MainMenu");
        AudioListener.volume = 1f;
        Debug.Log("Load Main Menu");

    }

    public void MusicCredits()
    {
        // to the music credits
        SceneManager.LoadScene("MusicCredits");
        AudioListener.volume = 1f;
        Debug.Log("Load Music Credits");

    }

    public void ExitGame()
    {
        // exit the game
        Application.Quit();
        Debug.Log("Closing the Game");
    }
}
