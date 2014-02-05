using UnityEngine;
using System.Collections;

public class TankMove : TankSub{

    public TankSub tanksub;
	void Start () {
                                    

        tanksub.GetComponent<TankSub>();
        //rigidbody.centerOfMass = new Vector3(0, -400, 0);
	}
	
	// Update is called once per frame
	void Update () {

        tanksub.Andar();
        tanksub.Rotacionar();
        //tanksub.RotacionarCanhao();
	}
}
