using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_interactions_nv3 : MonoBehaviour
{
    public HingeJoint hinge1;
    public HingeJoint hinge2;
    public HingeJoint hinge3;
    public HingeJoint hinge4;
    public HingeJoint hinge5;
    public GameObject porte1Gauche;
    public GameObject porte1Droite;
    void Start()
    {

    }

    void Update()
    {
        float angle = hinge1.angle;

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
