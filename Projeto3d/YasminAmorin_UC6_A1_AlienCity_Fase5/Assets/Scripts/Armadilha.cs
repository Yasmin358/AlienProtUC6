using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Armadilha : MonoBehaviour
{
    public int dano = 0;

    public void DanoTempo(float timer, float waitTimer, int danoArmadilha)
    {
        timer += Time.deltaTime;

        if (timer > waitTimer)
        {
            timer = timer - waitTimer;
        }
    }

}