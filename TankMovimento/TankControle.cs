using UnityEngine;
using System.Collections;

public class TankControle : MonoBehaviour {

    public WheelCollider[] RodaFrente;
    public WheelCollider[] RodaParaTras;

    public Transform[] wheelsF;
    public Transform[] wheelsB;

    public float wheelOffset = 0.1f;
    public float wheelRadius = 0.13f;


    public float maxSteer = 30;
    public float maxAccel = 25;
    public float maxBrake = 50;

    public Transform Com;

    public class WheelData
    {
        public Transform WheelTransform;
        public WheelCollider col;
        public Vector3 wheelStarPos;
        public float rotation = 0.0f;
    }

    protected WheelData[] wheels;

	// Use this for initialization
	void Start () {

        rigidbody.centerOfMass = Com.localPosition;

        wheels = new WheelData[RodaFrente.Length + RodaParaTras.Length];

        for (int i = 0; i < RodaFrente.Length; i++)
        {
            wheels[i] = SetupWheels(wheelsF[i], RodaFrente[i]);
        }

        for (int i = 0; i < RodaParaTras.Length; i++)
        {
            wheels[i + RodaFrente.Length] = SetupWheels(wheelsB[i], RodaParaTras[i]);
        }

	}

    private WheelData SetupWheels(Transform wheel, WheelCollider col)
    {
        WheelData result = new WheelData();

        result.WheelTransform = wheel;
        result.col = col;
        result.wheelStarPos = wheel.transform.localPosition;

        return result;
    }

    void FixedUpdate()
    {
        float accel = 0;
        float steer = 0;

        accel = Input.GetAxis("Vertical");
        steer = Input.GetAxis("Horizontal");

        TankAndar(accel, steer);
        UpdateWheels();

    }

    private void UpdateWheels()
    {
        float delta = Time.fixedDeltaTime;

        foreach (WheelData w in wheels)
        {
            WheelHit hit;

            Vector3 lp = w.WheelTransform.localPosition;
            if (w.col.GetGroundHit(out hit))
            {
                lp.y -= Vector3.Dot(w.WheelTransform.position - hit.point, transform.up) - wheelRadius;

            }
            else
            {
                lp.y = w.wheelStarPos.y - wheelOffset;
            }

            w.WheelTransform.localPosition = lp;


            w.rotation = Mathf.Repeat(w.rotation + delta * w.col.rpm * 360.0f / 60.0f, 360.0f);
            w.WheelTransform.localRotation = Quaternion.Euler(w.rotation, w.col.steerAngle, 90.0f);
        }
    }

    private void TankAndar(float accel, float steer)
    {
        foreach (WheelCollider col in RodaFrente)
        {
            col.steerAngle = steer * maxSteer;
        } 
        
        if (accel == 0)
        {
            foreach (WheelCollider col in RodaParaTras)
            {
                col.brakeTorque = maxBrake;
            }
        }

        else
        {
            foreach (WheelCollider col in RodaParaTras)
            {
                col.brakeTorque = 0;
                col.motorTorque = accel * maxAccel;
            }
        }
    }
    // Update is called once per frame
	void Update () {
	
	}
}
