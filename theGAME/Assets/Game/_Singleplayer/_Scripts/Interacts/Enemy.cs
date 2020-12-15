/**
    * John Shields - G00348436
    * Enemy Script
    * When the Player collides Enemy slow down the game to 0.1 
    * Play sound at Camera's position - Wait 0.1 seconds, resume the normal game time and respawn the Player
*/

using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] AudioClip voice;
    [SerializeField] AudioClip death;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0.1f; // slow down game
        AudioSource.PlayClipAtPoint(voice, Camera.main.transform.position); // enemy sound
        AudioSource.PlayClipAtPoint(death, Camera.main.transform.position); // player death
        Debug.Log("Player is Dead");
        // call method to repawn the Player
        StartCoroutine(respawnPlayer());
    }

    IEnumerator respawnPlayer()
    {
        // wait for 0.1 seconds
        yield return new WaitForSeconds(0.1f); // has to be eqivalent to the time that is slowed down
        // resume the normal time
        Time.timeScale = 1f;
        // respawn the Player at last check point
        player.transform.position = respawnPoint.transform.position;
        Debug.Log("Player Respawned");
    }
}