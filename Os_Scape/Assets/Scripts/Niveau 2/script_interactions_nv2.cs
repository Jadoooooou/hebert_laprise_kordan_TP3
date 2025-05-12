using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_interactions_nv2 : MonoBehaviour
{
    public HingeJoint hinge1;
    //public HingeJoint hinge2;
    //public plateform animator
    public GameObject porteGauche;
    public GameObject porteDroite;
    void Start()
    {

    }

    void Update()
    {
        float angle = hinge1.angle;

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

        /*float angle = hinge2.angle;

        if (angle < -30f)
        {
            trigger anim plateform
        }
        else if (angle > 30f)
        {
            tigger stop plateform
        }*/
    }
}
