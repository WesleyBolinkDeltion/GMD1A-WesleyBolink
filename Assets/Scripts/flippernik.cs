using UnityEngine;
using System.Collections;

public class flippernik : MonoBehaviour
{

    public bool activateFlipper;
    public bool deActivateFlipper;
    public float activateTimer = 0f;
    public float deActivateTimer = 0f;
    public GameObject flipperPivot;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            activateFlipper = true;
        }

        if (activateTimer > 0.06f)
        {
            activateFlipper = false;
            activateTimer = 0f;

        }

        if (activateFlipper)
        {
            transform.RotateAround(transform.position, flipperPivot.transform.forward, -800 * Time.deltaTime);
            activateTimer = activateTimer + Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            deActivateFlipper = true;
        }

        if (deActivateTimer > 0.06f)
        {
            deActivateFlipper = false;
            deActivateTimer = 0f;

        }

        if (deActivateFlipper)
        {
            transform.RotateAround(transform.position, flipperPivot.transform.forward, 800 * Time.deltaTime);
            deActivateTimer = deActivateTimer + Time.deltaTime;
        }
    }
}