using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    [SerializeField] AudioClip pickupSound;
    private int bolts = 0;

    // rotate bolt
    void Update()
    {
        transform.Rotate(new Vector3(1f, 5f, 5f));
    }

    // play pickup sound, add score and delete bolt from game
    private void OnTriggerEnter(Collider other)
    {
            AudioSource.PlayClipAtPoint(pickupSound, Camera.main.transform.position);
            Destroy(gameObject);
            other.GetComponent<BoltCounter>().bolts++;
    }
}

