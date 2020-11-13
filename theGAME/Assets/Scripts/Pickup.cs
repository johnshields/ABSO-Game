using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    [SerializeField] AudioClip pickupSound;

    private void OnTriggerEnter(Collider collision)
    {
        AudioSource.PlayClipAtPoint(pickupSound, Camera.main.transform.position);
        Destroy(gameObject);
    }
    

}
