using UnityEngine;
using System.Collections;

public class Bumperscore : MonoBehaviour {

    public void OnCollisionEnter(Collision collision)
    {
        Scoreboard.score += 10;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    }
}
