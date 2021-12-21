using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
   int Speed = 25;
   
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (0, Speed * Time.deltaTime, 0);
    }
   
    

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player" ){
            other.GetComponent<PlayerController>().SetChaves(1);     
            Destroy(gameObject);
        }
    }
}
