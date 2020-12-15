/**
    * John Shields - G00348436
    * Player 2 Double Bolts Script
    * Double Bolts collected in game for Player 2 - Rotate Double Bolt
    * When PLayer 2 collides with Double Bolt play sound at Camera's position
    * Destroy Double Bolt from game - add Double Bolts to the Player 1's Bolt Counter
*/

using UnityEngine;

public class P2doubleBolts : MonoBehaviour
{
    [SerializeField] AudioClip P2doubleBoltsSound;

    // rotate Bolt
    void Update()
    {
        transform.Rotate(new Vector3(1f, 5f, 5f));
    }

    // play sound at the Camera's position
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(P2doubleBoltsSound, Camera.main.transform.position);
        Destroy(gameObject); // destroy Bolt
        // add bolt x 2 to the bolt counter
        other.GetComponent<P2boltCounter>().P2bolts+=2;
        Debug.Log("Add +2 Bolts to Bolt Counter and Double Bolt destroyed from Game");
    }
}

