using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmadilhaLava : Armadilha
{
 
    private void OnTriggerStay(Collider other) {
      if(other.gameObject.CompareTag("Player")){
        DanoTempo(0.01f, 1);
        
      }
    }
}