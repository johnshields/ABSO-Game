using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hMove = Input.GetAxis("Horizontal") * moveSpeed / 2;
        float vMove = Input.GetAxis("Vertical") * moveSpeed;

        transform.Translate(new Vector3(hMove, 0, vMove) * Time.deltaTime);
    }
}
