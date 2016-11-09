using UnityEngine;
using System.Collections;

public class Canvas : MonoBehaviour {

    public GameObject playStart;
    public void StartGame()
    {
        playStart.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();

    }

    // Use this for initialization
    void Start () {
        playStart.SetActive(true);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
