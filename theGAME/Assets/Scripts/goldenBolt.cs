using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldenBolt : MonoBehaviour
{
    [SerializeField] AudioClip pickupSound;
    void Update()
    {
        transform.Rotate(new Vector3(1f, 1f, 1f));
    }

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
