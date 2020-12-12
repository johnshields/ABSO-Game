/**
    * John Shields - G00348436
    * Next Level Script
    * When Player collides with Object load the next scene in the game's build
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    private int nextSceneToLoad;
    void Start()
    {
        // load the next scene in the build
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0.5f; // slow game down
        // load scene
        SceneManager.LoadScene(nextSceneToLoad);
        Time.timeScale = 1.0f; // normal game time
    }
}
