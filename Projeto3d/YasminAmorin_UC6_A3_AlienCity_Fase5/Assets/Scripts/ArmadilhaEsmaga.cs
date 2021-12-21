using UnityEngine;

public class ArmadilhaEsmaga : Armadilha {
    
    public GameObject MoveParede;
    

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player")){
             
             Dano(10);
             MoveParede.GetComponent<MoveParede>().gatilhoAtivado = false;             
                     
        }

        
    }
}