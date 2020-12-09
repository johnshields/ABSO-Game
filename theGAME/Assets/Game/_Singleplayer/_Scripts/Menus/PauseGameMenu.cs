/**
    * John Shields - G00348436
    * Pause Game Menu - pause the game if pause button is pressed
    * buttons to resume game, back to main menu, multiplayer menu and exit game
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGameMenu : MonoBehaviour
{
    public GameObject pauseGMenu;
    public bool isPaused;

    void Start()
    {
        pauseGMenu.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            // if game is not pause play the game and audio as normal
            if(isPaused)
            {   
                ResumeGame();
                AudioListener.volume = 1f;
            }
            // if the game is paused stop the game and audio
            else
            {   
                PauseTheGame();
                AudioListener.volume = 0f;
            }

        }
    }

    public void PauseTheGame()
    {
        // when pause is button clicked bring up pause menu 
        pauseGMenu.SetActive(true);
        Time.timeScale = 0f; // slow the game down to 0
        AudioListener.volume = 0f; // pause audio
        isPaused = true; // game is paused
    }

    public void ResumeGame()
    {
        // when resume is button clicked close pause menu
        pauseGMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false; // game is not paused
        AudioListener.volume = 1f; // resume audio level
    }

    public void BackMainMenu()
    {
        // to the main menu
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        AudioListener.volume = 1f;
        // restart main menu audio
        MenuAudio.Instance.gameObject.GetComponent<AudioSource>().Play();
    }

    public void MPmenu()
    {
        // to the multiplayer menu
        Time.timeScale = 1f;
        SceneManager.LoadScene("MultiplayerMenu");
        AudioListener.volume = 1f;
        MenuAudio.Instance.gameObject.GetComponent<AudioSource>().Play();
    }

    public void ExitGame()
    {
        // exit the game
        Application.Quit();
    }
}
