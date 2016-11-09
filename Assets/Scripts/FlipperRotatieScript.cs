using UnityEngine;
using System.Collections;

public class FlipperRotatieScript : MonoBehaviour
{

    public bool activateFlipper;
    public float timer = 0;
    public GameObject flipperPivot;
    public Rigidbody ball;
    public void OnCollisionEnter(Collision collision)
        {
            ball.AddForce(-10, 0, -3);
        }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            activateFlipper = true;
        }

        if (timer > 0.06f)
        {
            activateFlipper = false;
            
        }
        if (activateFlipper)
        {
            transform.RotateAround
                (transform.position,
                flipperPivot.transform.up,
                800 * Time.deltaTime);
            timer = timer + Time.deltaTime;
        }
    }
}