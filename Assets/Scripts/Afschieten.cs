using UnityEngine;
using System.Collections;

public class Afschieten : MonoBehaviour {

    public Vector3 direction;
    public Rigidbody ball;

    public void OnTriggerStay(Collider collider)
    {
        if (Input.GetButton("Jump"))
        {
            ball.AddForce(direction);
        }
    }

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

    }
}
