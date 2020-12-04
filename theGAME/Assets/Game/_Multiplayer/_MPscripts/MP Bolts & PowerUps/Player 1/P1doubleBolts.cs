using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1doubleBolts : MonoBehaviour
{
    [SerializeField] AudioClip P1doubleBoltsSound;

    // rotate bolt
    void Update()
    {
        transform.Rotate(new Vector3(1f, 5f, 5f));
    }

    // play pickup sound, add score and delete bolt from game
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(P1doubleBoltsSound, Camera.main.transform.position);
        Destroy(gameObject);

        // add to the bolt counter
        other.GetComponent<P1boltCounter>().P1bolts+=2;
    }
}

