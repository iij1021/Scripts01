using UnityEngine;
using System.Collections;

public class FisicaCarro : MonoBehaviour
{

  
 
    //public float h = 30f;
    //public float v = 30f;
    //public Vector3 vc = Vector3.zero;
    //public Vector3 Rotacionar;


    
    //public Texture BotaoTextura;

    // Botoes
    //public float BotaoX = 0.15f;
    //public float BotaoY = 0.75f;
    //public float BotaoAltura = 0.11f;
    //public float BotaoLargura = 0.09f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Mover();

    }
   
    public void Mover()
    {

        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(0, 0, 20 * Time.deltaTime);
        }else if(Input.GetAxis("Vertical") < 0){

            transform.Translate(0,0,-20*Time.deltaTime);
        }

        // Rotaticionar canhao

        if(Input.GetAxis("Horizontal") > 0){

            transform.Rotate(0,20*Time.deltaTime,0);
        }
        else if(Input.GetAxis("Horizontal") < 0){
            
            transform.Rotate(0,-20*Time.deltaTime,0);

        }


       
    }
}           
	