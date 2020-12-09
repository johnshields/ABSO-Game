/**
    * John Shields - G00348436
    * Player 2 Golden Bolt Script
    * Golden Bolts collected in game for Player 2 - Rotate Golden Bolt
    * When PLayer collides with Golden Bolt play sound at Camera's position
    * Destroy Golden Bolt from game - add Golden Bolt to the Player 2's Bolt Counter
*/

using UnityEngine;

public class P2goldenBolt : MonoBehaviour
{
    [SerializeField] AudioClip P2pickupSound;
    void Update()
    {
        // rotate Golden Bolt
        transform.Rotate(new Vector3(1f, 1f, 1f));
    }

    private void OnTriggerEnter(Collider other)
    {
        // play pickup sound, add score and delete bolt from game
        if (other.name == "Player")
        {
            // play sound at the Camera's position
            AudioSource.PlayClipAtPoint(P2pickupSound, Camera.main.transform.position);
            Destroy(gameObject); // destroy Golden Bolt
            // add bolt x 10 to the bolt counter
            other.GetComponent<P2boltCounter>().P2bolts += 10;
        }
    }
}
