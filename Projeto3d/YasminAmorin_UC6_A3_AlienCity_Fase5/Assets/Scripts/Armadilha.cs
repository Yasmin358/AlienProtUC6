using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Armadilha : MonoBehaviour
{
    public GameObject player;
    
    float timer = 0;
    

    public void DanoTempo(float waitTimer, int dano)
    {
        timer += Time.deltaTime;
        
            if(timer > waitTimer){
                timer = timer - waitTimer;
                Dano(dano);
            }
            
            
    }       
    public void Dano(int dano){
        player.GetComponent<PlayerController>().DanoPlayer(dano);
    }        
            
            
        
        
       
        
            
            
        
    

}