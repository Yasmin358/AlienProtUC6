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
            Instantiate(projetil, new Vector3(posição.transform.position.x, posição.transform.position.y, posição.transform.position.z), Quaternion.identity);
        }
    }

}