using UnityEngine;
using System.Collections;

public class TankAndar : MonoBehaviour {

    public WheelCollider[] Rodas01;
    public WheelCollider[] Rodas02;

    public float Aceleracao;
    public float Freiagem;
    public float Turbo;

    public WheelCollider col;


    public void Forward()
    {
        float h = Input.GetAxis("Horizontal") * Aceleracao;
        float v = Input.GetAxis("Vertical") * Aceleracao;

        if (h > 0)
        {
            col.motorTorque = h;
        }
        else
        {
            col.motorTorque = 0;
        }
        
    }
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        Forward();
	
	}


}
