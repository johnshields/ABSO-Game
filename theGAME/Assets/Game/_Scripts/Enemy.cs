using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] AudioClip voice;
    [SerializeField] AudioClip death;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        // BoxCollider bc = gameObject.AddComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(voice, Camera.main.transform.position);
        AudioSource.PlayClipAtPoint(death, Camera.main.transform.position);
        player.transform.position = respawnPoint.transform.position;
    }
}