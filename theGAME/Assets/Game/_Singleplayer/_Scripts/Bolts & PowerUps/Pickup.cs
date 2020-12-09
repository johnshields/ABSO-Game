/**
    * John Shields - G00348436
    * Pickup Bolts Script
    * Regular Bolts collected in game for Player - Rotate Bolt 
    * When PLayer collides with Bolt play sound at Camera's position
    * Destroy Bolt from game - add Bolt to the Player's Bolt Counter
*/

using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] AudioClip pickupSound;

    void Update()
    {
        // rotate Bolt
        transform.Rotate(new Vector3(1f, 5f, 5f));
    }

    private void OnTriggerEnter(Collider other)
    {
        // player sound at the Camera's position
        AudioSource.PlayClipAtPoint(pickupSound, Camera.main.transform.position);
        Destroy(gameObject); // destroy Bolt
        // add to the Bolt Counter
        other.GetComponent<BoltCounter>().bolts+=1;
    }
}

