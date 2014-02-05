using UnityEngine;
using System.Collections;

public class GravidadeRodas : MonoBehaviour{

   //ublic WheelCollider RodaGravidade;
    public TankSub Sub;
    public float Gravidade = 62.66f;
    public bool TankNoChao;
	void Start () {

        Sub.GetComponent<TankSub>();
	
	}
	
	// Update is called once per frame
	void Update () {

        if (TankNoChao == false)
        {
            Physics.gravity = new Vector3(0, -Gravidade * 2, 0);
           // Debug.Log("Gravidade Funcionando");
        }
	}
}
