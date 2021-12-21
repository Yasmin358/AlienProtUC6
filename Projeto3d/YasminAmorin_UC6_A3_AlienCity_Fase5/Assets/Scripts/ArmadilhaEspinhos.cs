using UnityEngine;

public class ArmadilhaEspinhos : Armadilha {
    

private void OnTriggerStay(Collider other) {
        if(other.gameObject.CompareTag("Player")){
            DanoTempo(0.03f, 5);
        }
    }




}