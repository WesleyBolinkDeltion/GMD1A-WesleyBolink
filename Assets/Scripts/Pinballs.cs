using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pinballs : MonoBehaviour
{

    public Text pinballScoreboard;
    public static int pinballsremaining;
    public GameObject pinball;

    // Use this for initialization
    void Start()
    {
        pinballsremaining = 3;
    }

    // Update is called once per frame
    void Update()
    {
        pinballScoreboard.text = "Pinballsremaining: " + pinballsremaining;

        if (pinballsremaining == 0)
        {
            pinball.SetActive(false);
        }
    }
}
