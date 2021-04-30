using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class KeyDoor : MonoBehaviour{

    private int chavesColetadas = 0;

    public void ColetarChaves(int chaves){
           chavesColetadas = chavesColetadas + chaves;
            print(chavesColetadas);
        
    }

    public int Chaves(){
        return chavesColetadas;
    }
}