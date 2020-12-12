/**
    * John Shields - G00348436
    * Splash Screen Script
    * Splash Screens for inbetween levels
    * Pause the audio from the Main Menu - Button to load next scene in the game's build
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    void Start()
    {
        // pauseAudio from Main Menu
        MenuAudio.Instance.gameObject.GetComponent<AudioSource>().Stop();
    }
    // button to next screen
    public void Continue()
    {
        // load the next scene in the build
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
