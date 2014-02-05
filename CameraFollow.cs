using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Transform Alvo;
  /// <summary>
  /// Codigo feito em 3/02/2014
  /// </summary>
    private float Altura = 2.3f;
    private float Distancia = 11.93f;
    public float Rotacao;
    public float BolaMousePositiva;
    public float BolaMouseNegativa;
    // vector 
    public Vector3 vc = Vector3.zero;


    public void CameraTerceiraPessoa()
    {
        

            vc = Alvo.position + Alvo.up * Altura - Alvo.forward * Distancia;
            transform.position = vc;
            transform.LookAt(Alvo.position);
        

    }
 
	// Update is called once per frame
	void FixedUpdate () {


        CameraTerceiraPessoa();
      

        }
}

