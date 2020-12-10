/**
    * John Shields - G00348436
    * Golden Bolt Script
    * Golden Bolts collected in game for Player - Rotate Golden Bolt
    * When PLayer collides with Golden Bolt play sound at Camera's position
    * Destroy Golden Bolt from game - add Golden Bolt to the Player's Bolt Counter
*/

using UnityEngine;

public class goldenBolt : MonoBehaviour
{
    [SerializeField] AudioClip pickupSound;
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
            AudioSource.PlayClipAtPoint(pickupSound, Camera.main.transform.position);
            Destroy(gameObject); // destroy Golden Bolt
            // add bolt x 10 to the bolt counter
            other.GetComponent<BoltCounter>().bolts += 10;

        }
    }
}
