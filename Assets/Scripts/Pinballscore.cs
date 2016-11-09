using UnityEngine;
using System.Collections;

public class Pinballscore : MonoBehaviour {

    public void OnCollisionEnter(Collision collision)
    {
        Pinballs.pinballsremaining -= 1;
    }
    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
