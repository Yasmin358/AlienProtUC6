using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaController : MonoBehaviour
{
    public GameObject projetil;
    public GameObject posição;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            Instantiate(projetil, posição.transform.position, posição.transform.rotation);
        }
    }

}