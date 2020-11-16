using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 25f;
    [SerializeField] public float jumpHeight = 20f;
    [SerializeField] public float Feet = 20f;
    [SerializeField] AudioClip playerSound;
    [SerializeField] AudioClip jumpSound;
    CapsuleCollider myBodyCollider;
    BoxCollider bc;
    Rigidbody rb;
    bool IsAlive;
    public int bolts = 0;

    // Start is called before the first frame update
    void Start()
    {
        IsAlive = true;
        rb = GetComponent<Rigidbody>();
        myBodyCollider = GetComponent<CapsuleCollider>();
        AudioSource.PlayClipAtPoint(playerSound, Camera.main.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(!IsAlive) { return;  }
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
                AudioSource.PlayClipAtPoint(jumpSound, Camera.main.transform.position);

            }
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(500, 0, 200, 50), "Bolts : " + bolts);
    }
}
