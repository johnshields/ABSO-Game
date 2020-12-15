/**
    * John Shields - G00348436
    * Player 1 Double Bolts Script
    * Double Bolts collected in game for Player 1 - Rotate Double Bolt
    * When PLayer 1 collides with Double Bolt play sound at Camera's position
    * Destroy Double Bolt from game - add Double Bolts to the Player 1's Bolt Counter
*/

using UnityEngine;

public class P1doubleBolts : MonoBehaviour
{
    [SerializeField] AudioClip P1doubleBoltsSound;

    void Update()
    {
         // rotate Bolt
        transform.Rotate(new Vector3(1f, 5f, 5f));
    }

        private void OnTriggerEnter(Collider other)
    {
        // play sound at the Camera's position
        AudioSource.PlayClipAtPoint(P1doubleBoltsSound, Camera.main.transform.position);
        Destroy(gameObject); // destroy Bolt
        // add bolt x 2 to the bolt counter
        other.GetComponent<P1boltCounter>().P1bolts+=2;
        Debug.Log("Add +2 Bolts to Bolt Counter and Double Bolt destroyed from Game");
    }
}
