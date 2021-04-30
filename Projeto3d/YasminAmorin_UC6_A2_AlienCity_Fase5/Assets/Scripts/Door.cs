using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    
    bool abrirPorta = false;
    public Transform openDoor;
    public Transform door;
    float SpeedDoor = 25;
    Vector3 open;
    

    void Start()
    {
        open = openDoor.position;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(abrirPorta == true){
        door.transform.position = Vector3.MoveTowards(door.transform.position, open , SpeedDoor* Time.deltaTime);
        }
        
        
    }

    

    


   private void OnTriggerEnter(Collider other) {
    
        if (other.gameObject.tag == "Player")
        {    
            if(other.GetComponent<PlayerController>().chaves == 2){
               abrirPorta = true; 
            }        
            
        }
    }




    
}
