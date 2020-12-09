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
        SceneManager.LoadScene("MP_EndBox");
    }
}
