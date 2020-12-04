using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoubleBolts : MonoBehaviour
{
    [SerializeField] AudioClip doubleBoltsSound;

    // rotate bolt
    void Update()
    {
        transform.Rotate(new Vector3(1f, 5f, 5f));
    }

    // play pickup sound, add score and delete bolt from game
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(doubleBoltsSound, Camera.main.transform.position);
        Destroy(gameObject);

        // add to the bolt counter
        other.GetComponent<BoltCounter>().bolts+=2;
    }
}

