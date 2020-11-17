using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    private int nextSceneToLoad;

    public int playerBolts;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt ("alreadyGotBolts", playerBolts);

        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
