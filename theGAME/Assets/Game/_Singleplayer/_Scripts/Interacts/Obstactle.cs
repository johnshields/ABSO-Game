/**
    * John Shields - G00348436
    * Obstactle Script
    * When the Player hits obstacle play sound at Camera's position
*/

using UnityEngine;

public class Obstactle : MonoBehaviour
{
    [SerializeField] AudioClip hitSound;

    private void OnTriggerEnter(Collider collision)
    {
        // when the Player hits obstacle play sound 
        AudioSource.PlayClipAtPoint(hitSound, Camera.main.transform.position);
    }
}
