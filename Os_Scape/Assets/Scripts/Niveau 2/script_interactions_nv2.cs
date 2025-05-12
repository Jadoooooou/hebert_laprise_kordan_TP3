using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_interactions_nv2 : MonoBehaviour
{
    public HingeJoint hinge;
    public GameObject porte1Gauche;
    public GameObject porte1Droite;
    void Start()
    {

    }

    void Update()
    {
        float angle = hinge.angle;

        if (angle < -30f)
        {
            porte1Gauche.SetActive(false);
            porte1Droite.SetActive(true);
        }
        else if (angle > 30f)
        {
            porte1Droite.SetActive(false);
            porte1Gauche.SetActive(true);
        }
    }
}
