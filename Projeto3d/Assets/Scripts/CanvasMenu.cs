using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasMenu : MonoBehaviour
{
   public GameObject PainelCredit;
    void Start()
    {
        PainelCredit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        SceneManager.LoadScene(1);
    }

    public void CreditsGame(){
       
       PainelCredit.SetActive(true);
    }

    public void BackMenu(){
        PainelCredit.SetActive(false);
    }
}
