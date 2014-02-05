using System.Collections;
using UnityEngine;

public class Fogo : MouseMecher {

    public Transform objecto;
    public float VelocidadeTiro = 3000;
    public float PenteBalas = 10;
    public float PenteVazio = 0;
    public Rigidbody prefab_Bala;

    void Update()
    {
        StartCoroutine(MinhaRotina());
    }
	
         IEnumerator  MinhaRotina(){

           if (PenteBalas > 0) // ESta é a minha  rotina //
           {

                if (Input.GetButtonDown("Fire1"))
                {
                    Debug.Log("UM Tiro");
                    Rigidbody corpo;
                    corpo = Instantiate(prefab_Bala, transform.position, transform.rotation) as Rigidbody;
                    corpo.AddForce(objecto.forward * VelocidadeTiro * 3);
                    PenteBalas -= 1;
                   
                   Debug.Log("Menos uma Bala" + PenteBalas);
                }
   
            }

           else if (PenteBalas == 0) // verifica se pente esta vazio  
           {
            
               if (Input.GetKey(KeyCode.R)) // funcao de recaregar  
               {  
                   Debug.Log("Recarregando");
                   yield return new WaitForSeconds(5); // tempo para recarregar 5 segundos
                   Debug.Log("Recarregado");
                   PenteBalas = 10;
               }
           }
            
         } // Fim da Rotina //
    } 

   

		
	

