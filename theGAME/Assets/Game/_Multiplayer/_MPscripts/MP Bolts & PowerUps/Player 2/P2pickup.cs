﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2pickup : MonoBehaviour
{
    [SerializeField] AudioClip P2pickupSound;

    // rotate bolt
    void Update()
    {
        transform.Rotate(new Vector3(1f, 5f, 5f));
    }

    // play pickup sound, add score and delete bolt from game
    private void OnTriggerEnter(Collider other)
    {
            AudioSource.PlayClipAtPoint(P2pickupSound, Camera.main.transform.position);
            Destroy(gameObject);

            // add to the bolt counter
            other.GetComponent<P2boltCounter>().P2bolts+=1;
    }
}
