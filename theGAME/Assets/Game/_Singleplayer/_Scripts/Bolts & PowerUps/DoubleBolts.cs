/**
    * John Shields - G00348436
    * Double Bolts Script
    * Double Bolts collected in game for Player - Rotate Double Bolt
    * When PLayer collides with Double Bolt play sound at Camera's position
    * Destroy Double Bolt from game - add Double Bolts to the Player's Bolt Counter
*/

using UnityEngine;

public class DoubleBolts : MonoBehaviour
{
    [SerializeField] AudioClip doubleBoltsSound;

    void Update()
    {
        // rotate Double Bolt
        transform.Rotate(new Vector3(1f, 5f, 5f));
    }

    private void OnTriggerEnter(Collider other)
    {
        // play sound at the Camera's position
        AudioSource.PlayClipAtPoint(doubleBoltsSound, Camera.main.transform.position);
        Destroy(gameObject); // destroy Double Bolt
        // add bolt x 2 to the bolt counter
        other.GetComponent<BoltCounter>().bolts+=2;
    }
}
