using UnityEngine;
using System.Collections;

public class TankSub : MonoBehaviour
{
    public float speed = 10f;
   //ublic float gravidade;
    private float rotacao = 15f;
    public float Turbo = 30f;
    public Vector3 vc = Vector3.zero;

    // Rodas 01
    public WheelCollider roda01;
    public WheelCollider roda02;
    public WheelCollider roda03;
    public WheelCollider roda04;
    public WheelCollider roda05;
    public WheelCollider roda06;
    public WheelCollider roda07;
    //Rodas 02
   public WheelCollider Proda01;
   public WheelCollider Proda02;
   public WheelCollider Proda03;
   public WheelCollider Proda04;
   public WheelCollider Proda05;
   public WheelCollider Proda06;
   public WheelCollider Proda07;

   public float h;
   public float v;


   
    public void Andar() {

       h = Input.GetAxis("Vertical") * speed;
       v = Input.GetAxis("Horizontal") * rotacao;

        if (h > 0)
        {
            vc = new Vector3(0, 0,h);
            transform.Translate(vc * Time.deltaTime);

            roda01.motorTorque = 2;
            roda02.motorTorque = 2;
            roda03.motorTorque = 2;
            roda04.motorTorque = 2;
            roda05.motorTorque = 2;
            roda06.motorTorque = 2;
            roda07.motorTorque = 2;

            Proda01.motorTorque = 2;
            Proda02.motorTorque = 2;
            Proda03.motorTorque = 2;
            Proda04.motorTorque = 2;
            Proda05.motorTorque = 2;
            Proda06.motorTorque = 2;
            Proda07.motorTorque = 2;
                                 
            Debug.Log("MotorTorque");


        }

        else if (h < 0)
        {
            vc = new Vector3(0, 0,-h);
            transform.Translate(vc * Time.deltaTime);


            roda01.motorTorque = 2;
            roda02.motorTorque = 2;
            roda03.motorTorque = 2;
            roda04.motorTorque = 2;
            roda05.motorTorque = 2;
            roda06.motorTorque = 2;
            roda07.motorTorque = 2;

            Proda01.motorTorque = 2;
            Proda02.motorTorque = 2;
            Proda03.motorTorque = 2;
            Proda04.motorTorque = 2;
            Proda05.motorTorque = 2;
            Proda06.motorTorque = 2;
            Proda07.motorTorque = 2;

            Debug.Log("MotorTorque -");
        }

    }
       public  void Rotacionar(){

        if (v > 0)
        {
            vc = new Vector3(0, v , 0);
            transform.Rotate(vc * Time.deltaTime);


            roda01.motorTorque = 2;
            roda02.motorTorque = 2;
            roda03.motorTorque = 2;
            roda04.motorTorque = 2;
            roda05.motorTorque = 2;
            roda06.motorTorque = 2;
            roda07.motorTorque = 2;

            Debug.Log("MotorRotacionar");

        }

        else if (v < 0)
        {
            vc = new Vector3(0, -v , 0);
            transform.Rotate(vc * Time.deltaTime);

            Proda01.motorTorque = 2;
            Proda02.motorTorque = 2;
            Proda03.motorTorque = 2;
            Proda04.motorTorque = 2;
            Proda05.motorTorque = 2;
            Proda06.motorTorque = 2;
            Proda07.motorTorque = 2;

            Debug.Log("MotorRotacionar");
        }

       }
           

    }
