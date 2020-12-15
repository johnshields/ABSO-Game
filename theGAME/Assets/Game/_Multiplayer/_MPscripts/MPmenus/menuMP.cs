/**
    * John Shields - G00348436
    * Multiplayer Menu Script
    * Buttons to other menus - Play game for PLayer 1 and Player 2
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class menuMP : MonoBehaviour
{
    public void Player1()
    {
        // play the game for Player 1
        SceneManager.LoadScene("P1_Splash Screen");
        Debug.Log("Player 1 Selected");
    }

    public void Player2()
    {
        // play the game for Player 2
        SceneManager.LoadScene("P2_Splash Screen");
        Debug.Log("Player 2 Selected");
    }

    public void BackMainMenu()
    {
        // to the menu menu
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        AudioListener.volume = 1f;
        Debug.Log("Load Main Menu");
    }
 
    public void MPmenu()
    {
        // to the multiplayer menu
        Time.timeScale = 1f;
        SceneManager.LoadScene("MultiplayerMenu");
        AudioListener.volume = 1f;
        // restart Main Menu Music
        MenuAudio.Instance.gameObject.GetComponent<AudioSource>().Play();
        Debug.Log("Load Multiplayer Menu");
    }
}
