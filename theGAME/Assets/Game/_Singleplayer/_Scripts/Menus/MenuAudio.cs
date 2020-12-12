/**
    * John Shields - G00348436
    * Menu Audio Script
    * Play the Main Menu Music globably throughout all menus
*/

using UnityEngine;

public class MenuAudio : MonoBehaviour
{

    private static MenuAudio instance = null;
    public static MenuAudio Instance
    {
        get {return instance;}
    }

    void Awake()
    {
        // don't destroy game object if this script is attached
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        } 
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    } 
}