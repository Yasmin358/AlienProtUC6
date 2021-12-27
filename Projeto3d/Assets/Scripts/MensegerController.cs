using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MensegerController : MonoBehaviour {
    public Text mensengerText;
    private GameObject Door;

    


    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Atirar")){
            
            mensengerText.text = "Pressione x para atirar";
            StartCoroutine(RotinaLimparTela());
        }

        if(other.gameObject.CompareTag("Chave")){
            
            mensengerText.text = "Chave Coletada!";
            StartCoroutine(RotinaLimparTela());
        }
        if(other.gameObject.CompareTag("door") && other.gameObject.GetComponent<Door>().Porta() == false){
            
            mensengerText.text = "Você precisa de duas chaves para abrir a porta!";
            StartCoroutine(RotinaLimparTela());
        }
    }

    IEnumerator RotinaLimparTela(){
           yield return new WaitForSeconds(2);
           mensengerText.text = " ";      
    }
}