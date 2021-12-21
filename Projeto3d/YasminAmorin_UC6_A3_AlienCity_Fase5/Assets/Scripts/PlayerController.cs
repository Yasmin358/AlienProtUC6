using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    
    float MoveSpeed = 10;
    float RotationSpeed = 100;
    CharacterController cc;
    private Animator anim;
    protected Vector3 gravidade = Vector3.zero;
    protected Vector3 move = Vector3.zero;
    private bool jump = false;
    [HideInInspector] public int pontuacao = 0;
    [HideInInspector] public int vida = 100;   
   
    public int chaves;

    void Start()
    {
        cc = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * MoveSpeed;
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * RotationSpeed * Time.deltaTime, 0));

        if (!cc.isGrounded)
        {
            gravidade += Physics.gravity * Time.deltaTime;
        }
        else
        {
            gravidade = Vector3.zero;
            if (jump)
            {
                gravidade.y = 5f;
                jump = false;
            }
        }
        move += gravidade;
        cc.Move(move * Time.deltaTime);
        Anima();

        
            
        
    }

    void Anima()
    {
        if (!Input.anyKey)
        {
            anim.SetTrigger("Parado");
        }
        else
        {
            if (Input.GetKeyDown("space"))
            {
                anim.SetTrigger("Pula");
                jump = true;
            }
            else
            {
                anim.SetTrigger("Corre");
            }
        }
    }

    public void DanoPlayer(int dano){
        if(vida == 0){
         print("Game Over");
        }else{
           vida = vida - dano;
        }
    }

    public void SetPontuacao(int pontuar){        
        pontuacao = pontuacao + pontuar;
                   
    }

   

    public void SetChaves(int keys){
        chaves = chaves + keys;
    }
}