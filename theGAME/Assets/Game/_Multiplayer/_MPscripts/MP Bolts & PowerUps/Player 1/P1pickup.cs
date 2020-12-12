/**
    * John Shields - G00348436
    * Player 1 Pickup Bolts Script
    * Regular Bolts collected in game for Player 1 - Rotate Bolt
    * When PLayer 1 collides with Bolt play sound at Camera's position
    * Destroy Bolt from game - add Bolt to the Player 1's Bolt Counter
*/

using UnityEngine;

public class P1pickup : MonoBehaviour
{
    [SerializeField] AudioClip pickupSound;

    // rotate Bolt
    void Update()
    {
        transform.Rotate(new Vector3(1f, 5f, 5f));
    }

    private void OnTriggerEnter(Collider other)
    {
        // play sound at the Camera's position
        AudioSource.PlayClipAtPoint(pickupSound, Camera.main.transform.position);
        Destroy(gameObject); // destroy Bolt
        // add to the Bolt Counter
        other.GetComponent<P1boltCounter>().P1bolts+=1;
    }
}
