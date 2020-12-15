/**
    * John Shields - G00348436
    * Multiplayer Splash Screen Script
    * Splash Screens for inbetween mutliplayer levels
    * Pause the audio from the Main Menu 
    * Buttons to reset Bolts for Player 1 and Player 2 and to load Level 1 for Player 1 and Player 2
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class MPsplashScreen : MonoBehaviour
{
    void Start()
    {
        // pauseAudio from Main Menu
        MenuAudio.Instance.gameObject.GetComponent<AudioSource>().Stop();
        Debug.Log("Main Menu music on hold");
    }
    
    // button to next screen
    public void P1Continue()
    {
        // reset bolts back to 0
        PlayerPrefs.SetInt("P1bolts", 0);
        // load first level
        SceneManager.LoadScene("P1-L1 SandBox");
        Debug.Log("Player 1's Bolts have been reset");
        Debug.Log("Load Player 1 into Level");
    }

    public void P2Continue()
    {
        // reset bolts back to 0
        PlayerPrefs.SetInt("P2bolts", 0);
        // load first level
        SceneManager.LoadScene("P2-L1 SandBox");
        Debug.Log("Player's Bolts have been reset");
        Debug.Log("Load Player 2 into Level");
    }
}
