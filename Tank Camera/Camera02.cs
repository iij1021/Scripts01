using UnityEngine;
using System.Collections;

public class Camera02 : MonoBehaviour {

	// Use this for initialization
    private Vector3 vector3;
    //public CameraFollow cameraPerseguir;
    public Transform CameraTopo;
    public float alturaTeto;


    public void CameraAlternativa()
    {
        vector3 = CameraTopo.position + CameraTopo.up * alturaTeto;
        transform.position = vector3;
        transform.LookAt(CameraTopo.position);
    }

	
	// Update is called once per frame
	void FixedUpdate () {

        CameraAlternativa();
	
	}
}
