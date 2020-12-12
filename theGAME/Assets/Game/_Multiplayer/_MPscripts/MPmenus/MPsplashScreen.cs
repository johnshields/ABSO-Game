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
    }
    
    // button to next screen
    public void P1Continue()
    {
        // reset bolts back to 0
        PlayerPrefs.SetInt("P1bolts", 0);
        // load first level
        SceneManager.LoadScene("P1-L1 SandBox");
    }

    public void P2Continue()
    {
        // reset bolts back to 0
        PlayerPrefs.SetInt("P2bolts", 0);
        // load first level
        SceneManager.LoadScene("P2-L1 SandBox");
    }
}
