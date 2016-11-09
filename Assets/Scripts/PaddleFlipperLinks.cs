using UnityEngine;
using System.Collections;

public class PaddleFlipperLinks : MonoBehaviour
{

    public float amount = 500000f;

    void Start()
    {
        GetComponent<Rigidbody>().maxAngularVelocity = 25;
    }



    void FixedUpdate()
    {

        if (Input.GetButton("Fire2"))
        {
            GetComponent<Rigidbody>().AddTorque(transform.forward * amount, ForceMode.Impulse);

        }
        else
        {
            GetComponent<Rigidbody>().AddTorque(transform.forward * -amount * Time.deltaTime, ForceMode.Impulse);
        }
    }
}

