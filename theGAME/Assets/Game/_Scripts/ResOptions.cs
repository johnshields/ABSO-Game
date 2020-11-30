using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResOptions : MonoBehaviour
{
    public void SetResolution()
    {
        SetScreenRes();
    }

    void SetScreenRes()
    {
        // 648, 720, 1080
        // getting the name of what we pressed
        string index = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        // change the resolution of the game
        switch(index)
        {
            case "480": // low
                Screen.SetResolution(640, 480, true);
                break;
            case "720": // med
                Screen.SetResolution(1360, 796, true);
                break;
            case "1080": // HD
                Screen.SetResolution(1980, 1080, true);
                break;
            case "DEFAULT": //default - HD
                Screen.SetResolution(1980, 1080, true);
                break;
        }
    }

    // save setting and return to options
    // note only works on an actual build of the game
    public void SAVEandReturn()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainOptions");
        AudioListener.volume = 1f;
    }
}
