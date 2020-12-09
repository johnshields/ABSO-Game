/**
    * John Shields - G00348436
    * Player 2 Pickup Bolts Script
    * Regular Bolts collected in game for Player 2 - Rotate Bolt 
    * When PLayer 2 collides with Bolt play sound at Camera's position
    * Destroy Bolt from game - add Bolt to the Player 2's Bolt Counter
*/

using UnityEngine;

public class P2pickup : MonoBehaviour
{
    [SerializeField] AudioClip P2pickupSound;

    // rotate Bolt
    void Update()
    {
        transform.Rotate(new Vector3(1f, 5f, 5f));
    }

    // play pickup sound, add score and delete bolt from game
    private void OnTriggerEnter(Collider other)
    {
        // play sound at the Camera's position
        AudioSource.PlayClipAtPoint(P2pickupSound, Camera.main.transform.position);
        Destroy(gameObject); // destroy Bolt
        // add to the Bolt Counter
        other.GetComponent<P2boltCounter>().P2bolts+=1;
    }
}

