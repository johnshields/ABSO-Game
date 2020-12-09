/**
    * John Shields - G00348436
    * Power Ups Script
    * In game Power Up's for Player - Rotate Power Up 
    * When PLayer collides with Power Up slow the game down
    * Play sound at Camera's position - Destroy Power Up
*/

using System.Collections;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] AudioClip powerUpSound;

    void Update()
    {
        // rotate the Power Up
        transform.Rotate(new Vector3(0f, 1.5f, 0f));
    }

    private void OnTriggerEnter(Collider other)
    {
        // play sound at the Camera's position
        AudioSource.PlayClipAtPoint(powerUpSound, Camera.main.transform.position);
        Destroy(gameObject); // destroy Power Up
    }
}