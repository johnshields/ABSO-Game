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
        // load scene
        SceneManager.LoadScene(nextSceneToLoad);
        Debug.Log("Load Player into Next Level");
    }
}
