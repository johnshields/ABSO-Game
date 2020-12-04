using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    [SerializeField] AudioClip powerUpSound;

    // rotate power up
    void Update()
    {
        transform.Rotate(new Vector3(0f, 1.5f, 0f));
    }

    // play power up sound, add score and delete power up from game
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(powerUpSound, Camera.main.transform.position);
        Destroy(gameObject);
    }
}

