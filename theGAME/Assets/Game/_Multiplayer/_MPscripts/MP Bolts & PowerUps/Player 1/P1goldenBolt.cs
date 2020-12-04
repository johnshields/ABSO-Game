using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1goldenBolt : MonoBehaviour
{
    [SerializeField] AudioClip P1pickupSound;
    void Update()
    {
        transform.Rotate(new Vector3(1f, 1f, 1f));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            AudioSource.PlayClipAtPoint(P1pickupSound, Camera.main.transform.position);
            other.GetComponent<P1boltCounter>().P1bolts += 10;
            Destroy(gameObject);
        }
    }
}
