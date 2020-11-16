using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    [SerializeField] AudioClip pickupSound;
    private int bolts;

    // rotate bolt
    void Update()
    {
        transform.Rotate(new Vector3(1f, 5f, 5f));
    }

    // play pickup sound, add score and delete bolt from game
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            AudioSource.PlayClipAtPoint(pickupSound, Camera.main.transform.position);
            other.GetComponent<Player>().bolts++;
            Destroy(gameObject);
        }
    }
}
