/**
    * John Shields - G00348436
    * Player 1 Golden Bolt Script
    * Golden Bolts collected in game for Player 1 - Rotate Golden Bolt
    * When PLayer 1 collides with Golden Bolt play sound at Camera's position
    * Destroy Golden Bolt from game - add Golden Bolt to the Player 1's Bolt Counter
*/

using UnityEngine;

public class P1goldenBolt : MonoBehaviour
{
    [SerializeField] AudioClip P1pickupSound;

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
            AudioSource.PlayClipAtPoint(P1pickupSound, Camera.main.transform.position);
            Destroy(gameObject); // destroy Golden Bolt
            // add bolt x 10 to the bolt counter
            other.GetComponent<P1boltCounter>().P1bolts += 10;
        }
    }
}
