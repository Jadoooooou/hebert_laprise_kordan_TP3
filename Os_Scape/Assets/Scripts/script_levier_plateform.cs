using UnityEngine;

public class LevierPlateform : MonoBehaviour
{
    public HingeJoint hinge;
    public Animator animPlatform;

    void Update()
    {
        float angle = hinge.angle; 

        if (angle < -30f)
        {
            animPlatform.SetTrigger("PlayAnim");
        }
        else if (angle > 30f)
        {
            animPlatform.SetTrigger("Idle");
        }
    }

}
