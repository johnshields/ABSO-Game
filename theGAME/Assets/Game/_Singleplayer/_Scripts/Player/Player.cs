/**
    * John Shields - G00348436
    * Player Script
    * Player movement - walk foward + move side to side
    * Player does not jump if is not touching the ground layer
*/

using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 25f;
    [SerializeField] public float jumpHeight = 20f;
    [SerializeField] public float Feet = 20f;
    [SerializeField] AudioClip jumpSound;
    [SerializeField] AudioClip playerSound;
    CapsuleCollider myBodyCollider;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        myBodyCollider = GetComponent<CapsuleCollider>();
        AudioSource.PlayClipAtPoint(playerSound, Camera.main.transform.position); // spawn sound
    }

    void Update()
    {
        Run();
        Jump();
    }

    private void Run()
    {
        // walk foward + move side to side
        float hMove = Input.GetAxis("Horizontal") * moveSpeed / 2;
        float vMove = Input.GetAxis("Vertical") * moveSpeed;
        transform.Translate(new Vector3(hMove, 0, vMove) * Time.deltaTime);
    }

    private void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            // player does not jump if is not touching the ground layer
            if (transform.position.y <=Feet) {
                GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight); // jump height
                AudioSource.PlayClipAtPoint(jumpSound, Camera.main.transform.position); // jump sound
            }
        }
    }
}

