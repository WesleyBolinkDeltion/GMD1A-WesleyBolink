using UnityEngine;
using System.Collections;

public class Bumperscript : MonoBehaviour {

    public Vector3 direction;
    public Rigidbody ball; 

    public void OnCollisionEnter(Collision collision)
    {
        ball.AddForce(direction);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
