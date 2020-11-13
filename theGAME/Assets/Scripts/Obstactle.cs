using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstactle : MonoBehaviour
{
    [SerializeField] AudioClip pickupSound;

    private void OnTriggerEnter(Collider collision)
    {
        AudioSource.PlayClipAtPoint(pickupSound, Camera.main.transform.position);
    }
}
