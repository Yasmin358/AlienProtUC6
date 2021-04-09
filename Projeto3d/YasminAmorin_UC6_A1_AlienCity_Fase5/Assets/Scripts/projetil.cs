using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetil : MonoBehaviour
{
    private float Speed = 150;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = Camera.main.transform.forward * Speed;
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider outro)
    {
        if (outro.gameObject.CompareTag("Quebravel") || outro.gameObject.CompareTag("parede"))
        {
            Destroy(gameObject);
        }
    }
}