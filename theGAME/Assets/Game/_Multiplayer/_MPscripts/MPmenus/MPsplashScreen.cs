using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MPsplashScreen : MonoBehaviour
{	
	// button to next screen
    public void P1Continue()
    {
        // load first level
        SceneManager.LoadScene("P1-L1 SandBox");
    }

    public void P2Continue()
    {
        // load first level
        SceneManager.LoadScene("P2-L1 SandBox");
    }
}
