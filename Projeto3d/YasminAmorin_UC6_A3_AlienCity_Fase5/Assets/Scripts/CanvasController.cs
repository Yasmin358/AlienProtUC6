using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    public Slider barraVida;
    
    private GameObject player;
    public Text scoreText;
    public Image Chave1;
    public Image Chave2;  

    private int vidaMaxima = 100;
    private int score; 
    

    void Start()
    {   
        player = GameObject.FindWithTag("Player");

        barraVida.minValue = 0;
        barraVida.maxValue = vidaMaxima;
        barraVida.value = vidaMaxima;  

    }
  
    void Update()
    {   
        controleVida();
        controlePontuacao();
        controleChaves();
    }

    private void controleVida(){

        barraVida.value = player.GetComponent<PlayerController>().vida;
        
        if(barraVida.value == 0){                             
          SceneManager.LoadScene(1);              
        }
    }

    private void controlePontuacao(){
        score = player.GetComponent<PlayerController>().pontuacao; 
        scoreText.text = "Pontuação: " + score.ToString();

    }

    private void controleChaves(){
        if(player.GetComponent<PlayerController>().chaves == 1){
            Chave1.color = new Color32 (252, 194, 0, 255);
        }else if(player.GetComponent<PlayerController>().chaves == 2){
            Chave2.color = new Color32 (252, 194, 0, 255);
        } 
    }

    
}
