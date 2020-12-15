/**
    * John Shields - G00348436
    * End Box Script
    * When Player 1 or Player 2 collides with Object load the Multiplayer End Box
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class endBox : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // load scene 'MP_EndBox'
        SceneManager.LoadScene("MP_EndBox");
    }

    public void Multiplayer()
    {
        // to the multiplayer menu
        SceneManager.LoadScene("MultiplayerMenu");
        MenuAudio.Instance.gameObject.GetComponent<AudioSource>().Play();
        Debug.Log("All Levels Complete");
        Debug.Log("Load Multiplayer Menu");
    }

    public void BackMainMenu()
    {
        // to the menu menu
        SceneManager.LoadScene("MainMenu");
        MenuAudio.Instance.gameObject.GetComponent<AudioSource>().Play();
        AudioListener.volume = 1f;
        Debug.Log("All Levels Complete");
        Debug.Log("Load Main Menu");
    }
}
