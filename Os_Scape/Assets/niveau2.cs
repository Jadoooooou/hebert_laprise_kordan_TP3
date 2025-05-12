using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class niveau2 : MonoBehaviour
{
    public HingeJoint hinge1;
    public Animator animPlatform;
    private bool hasPlayed = false;

    public HingeJoint hinge2;
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
            animPlatform.SetTrigger("PlayAnim");
        }
        else if (angle > 30f)
        {
            animPlatform.SetTrigger("StopAnim");
        }
    }
}
