using UnityEngine;

public class MoveParede : MonoBehaviour {
    
        
        public Transform paredeA;
        public Transform paredeB;
        public Transform pontoA;
        public Transform pontoB;
        Vector3 posParedeA;
        Vector3 posParedeB;
        [HideInInspector] public bool gatilhoAtivado;
        float Speed = 25;

        void Start(){
           
           posParedeA = paredeA.position;
           posParedeB = paredeB.position;
        }

        void Update(){
           
            if (gatilhoAtivado == true)
            {
                paredeA.position = Vector3.MoveTowards(paredeA.position, pontoA.position, Speed * Time.deltaTime);
                paredeB.position = Vector3.MoveTowards(paredeB.position, pontoB.position, Speed * Time.deltaTime);
               
            }else if(gatilhoAtivado == false){
                paredeA.position = Vector3.MoveTowards(paredeA.position, posParedeA, Speed * Time.deltaTime);
                paredeB.position = Vector3.MoveTowards(paredeB.position, posParedeB, Speed * Time.deltaTime);
            }
        }

        private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")){
            
            gatilhoAtivado = true;
           
        }
        }
        private void OnTriggerExit(Collider other) {
        if(other.gameObject.CompareTag("Player")){
            
            gatilhoAtivado = false;
           
        }
    }

        
     

}