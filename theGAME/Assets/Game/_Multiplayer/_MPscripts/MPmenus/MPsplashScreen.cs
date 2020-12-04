using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MPsplashScreen : MonoBehaviour
{	
	// button to next screen
    public void P1Continue()
    {
        // reset bolts back to 0
        PlayerPrefs.SetInt("P1bolts", 0);

        // play the game
        SceneManager.LoadScene("P1-L1 SandBox");
    }

    public void P2Continue()
    {
        // reset bolts back to 0
        PlayerPrefs.SetInt("P2bolts", 0);

        // play the game
        SceneManager.LoadScene("P2-L1 SandBox");
    }
}
