using UnityEngine;
using System.Collections;

public class coletarPedras : MonoBehaviour {

    int Speed = 20;

    void Start(){
        
    }
    
    void Update() {
        transform.Rotate (0,0,Speed * Time.deltaTime);
    }
    
        
    

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player" ){
           
           other.GetComponent<PlayerController>().SetPontuacao(10);
            Destroy(gameObject);
        }
    }
} 