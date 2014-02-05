using UnityEngine;
using System.Collections;

public class TrocaCamera : MonoBehaviour
{
    public Camera Camera01;
    public Camera Camera02;
    public int cameraOn;
    void FixedUpdate()
    {

        switch (cameraOn)
        {
            case 1:
                Camera01.enabled = true;
                break;
            case 2:
                Camera02.enabled = true;
                break;

            default:
                Debug.Log("Tecla invalida");
                break;
        }

    }
}