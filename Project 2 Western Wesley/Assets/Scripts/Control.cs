using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {
    public float movement = 50f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate((Vector3.forward) * movement * Time.deltaTime);
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            transform.Translate((Vector3.back) * movement * Time.deltaTime);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate((Vector3.right) * movement * Time.deltaTime);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate((Vector3.left) * movement * Time.deltaTime);
        }
    }
}
