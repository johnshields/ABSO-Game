using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 25f;
    [SerializeField] public float jumpHeight = 20f;
    [SerializeField] public float Feet = 20f;
    [SerializeField] AudioClip pickupSound;
    Rigidbody rb;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        AudioSource.PlayClipAtPoint(pickupSound, Camera.main.transform.position);
    }

    // Update is called once per frame
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
            if (transform.position.y <=Feet) {
                GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight);
                
            }
        }
    }
}
