using UnityEngine;
using System.Collections;

public class Flipper1 : MonoBehaviour {

    // Notities over dit script: 
    // Dit script is nog niet goed, het is alleen een beginnetje om bepaalde dingen uit te leggen
    // Het idee: we hebben een boolean waarde die aangeeft of de flipper mag bewegen of niet. 
    // Als we op de rechter shift drukken gaat de waarde aan en gaat de flipper bewegen met rotatearound
    // Gebruik een pivot gameobject om de rotatie goed te krijgen
    // Deze versie van het script wacht een bepaalde tijd voordat het de flipper stopt. 
    // Het kan ook op basis van de hoek, maar hoeken zijn erg lastig in Unity
    // Het script laat de flipper nog niet zakken. Zorg hier zelf voor. 
    // Het grote probleem is dat het lastig is de bal te lanceren met de flipper. 
    // Hiervoor kan je een addforce gebruiken als de bal de flipper raakt. 
    // Nu wordt de bal nog gelanceerd als de timer is afgelopen. Maar klopt dit wel? 

    public bool activateFlipper;
    public float timer = 0;
    public GameObject flipperPivot;

    public Rigidbody ball;

    void Update()
    {
        
        if (Input.GetButton("Fire1"))
        {
            activateFlipper = true;
        }
        // Deze timer is op basis van proberen vastgesteld. Misschien is er een betere manier? 
        if (timer > 0.08f)
        {
            activateFlipper = false;
            // Geen goede plek voor de addforce. Bedenk wanneer je de force wel wil toepassen. 
            // Is er een manier om een richting te geven aan de bal die niet altijd dezelfde richting is? 
            //ball.AddForce(-10, 0, -3);
        }
    }

    // FixedUpdate is een versie van Update die niet afhankelijk is van de framerate. 
    // Als je werkt met physics is deze vaak beter om te gebruiken. 
    void FixedUpdate() { 
        if (activateFlipper)
        {
            // RotateAround krijgt een positie die moet roteren, een positie waaromheen geroteerd wordt en een snelheid. 
            // Bedenk zelf een betere manier om de snelheid te gebruiken. 
            transform.RotateAround (transform.position, flipperPivot.transform.forward, -800 * Time.deltaTime);
            timer = timer + Time.deltaTime;
        }
    }
}
