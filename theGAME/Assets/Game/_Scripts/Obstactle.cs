using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstactle : MonoBehaviour
{
    [SerializeField] AudioClip hitSound;

    private void OnTriggerEnter(Collider collision)
    {
        AudioSource.PlayClipAtPoint(hitSound, Camera.main.transform.position);
    }
}
