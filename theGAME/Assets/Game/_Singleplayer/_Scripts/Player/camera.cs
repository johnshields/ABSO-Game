/**
    * John Shields - G00348436
    * Camera Script
    * Camera finds the Player's position - camera follows Player's position
*/

using UnityEngine;

public class camera : MonoBehaviour
{
    private Transform player;
    private float yOffset = 12f;
    private float zOffset = -5f;

    void Start()
    {
        // camera finds the  Player's position
        player = GameObject.Find("Player").transform;
        Debug.Log("Camera has found Player's position and is now following the Player");
    }

    void LateUpdate()
    {
        // camera follows Player's position
        transform.position = new Vector3(player.position.x, player.position.y + yOffset,player.position.z + zOffset);
    }
}
