using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2goldenBolt : MonoBehaviour
{
    [SerializeField] AudioClip P2pickupSound;
    void Update()
    {
        transform.Rotate(new Vector3(1f, 1f, 1f));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            AudioSource.PlayClipAtPoint(P2pickupSound, Camera.main.transform.position);
            other.GetComponent<BoltCounter>().bolts += 10;
            Destroy(gameObject);
        }
    }
}
