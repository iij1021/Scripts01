using UnityEngine;
using System.Collections;

public class CameraFolllow : MonoBehaviour {

    public Transform TargetPosition; // Posicao do tank
    public Vector3 Follow;  // Camera segue;
    public float Altura;
    public float Distancia;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Follow = TargetPosition.forward * Distancia + TargetPosition.up * Altura;

       
	}
}
