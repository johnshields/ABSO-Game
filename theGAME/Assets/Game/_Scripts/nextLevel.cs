using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    private int nextSceneToLoad;

    // Start is called before the first frame update
    void Start()
    {

        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
