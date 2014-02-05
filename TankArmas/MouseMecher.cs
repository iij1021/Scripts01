using UnityEngine;
using System.Collections;

public class MouseMecher : MonoBehaviour {

	//public Rigidbody Forca;
    public float rotacaoTank = 22.97f;
	public Vector3 vc = Vector3.zero;
    //public Transform ca;
    public float altura;
    public Texture Mira;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        CanhaoGirar();
        //CanhaoFixo();
    }
    public void CanhaoGirar(){

		vc = new Vector3(0,Input.GetAxis("Mouse X") * Time.deltaTime * rotacaoTank,0);
        transform.Rotate(vc);

        GUI.Label

    }
    //public void CanhaoFixo()
    //{
    //    vc = ca.position + ca.up * 1.67f;
    //    transform.position = vc;
    //}
}


