using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasMenu : MonoBehaviour
{
   public GameObject Painel;
    void Start()
    {
        Painel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        SceneManager.LoadScene(1);
    }

    public void CreditsGame(){
       
       Painel.SetActive(true);
    }

    public void BackMenu(){
        Painel.SetActive(false);
    }
    
     public void bottomExit(){
         Application.Quit();       
     }

     public void bottomMenu(){
        SceneManager.LoadScene(0);
     }

       public void Resume(){
        Painel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pause(){
       Painel.SetActive(true);
       Time.timeScale = 0f;
    }
}
