using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] AudioClip spider;
    [SerializeField] AudioClip death;

    // Start is called before the first frame update
    void Start()
    {
        BoxCollider bc = gameObject.AddComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        AudioSource.PlayClipAtPoint(spider, Camera.main.transform.position);
        AudioSource.PlayClipAtPoint(death, Camera.main.transform.position);
    }
}
