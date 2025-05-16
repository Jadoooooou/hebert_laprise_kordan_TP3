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
    void Update()
    {
        float angle = hinge.angle; 

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
