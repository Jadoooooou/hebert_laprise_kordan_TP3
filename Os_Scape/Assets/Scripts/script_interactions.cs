using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_levier_plateform : MonoBehaviour
{
    public HingeJoint hinge;
    public GameObject porteGauche;
    public GameObject porteDroite;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float angle = hinge.angle;  // Live angle in degrees

        if (angle < -30f)
        {
            porteGauche.SetActive(false);
            porteDroite.SetActive(true);
        }
        else if (angle > 30f)
        {
            porteDroite.SetActive(false);
            porteGauche.SetActive(true);
        }
    }
}
