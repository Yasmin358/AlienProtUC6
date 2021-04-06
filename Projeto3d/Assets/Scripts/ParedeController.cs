using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedeController : MonoBehaviour
{
    public int paredeVida = 3;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (paredeVida == 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider outro)
    {
        if (outro.gameObject.CompareTag("projetil"))
        {
            paredeVida = paredeVida - 1;
        }
    }
}