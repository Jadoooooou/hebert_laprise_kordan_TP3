using UnityEngine;

public class LevierPorteSimple : MonoBehaviour
{
    public HingeJoint hinge;
    public GameObject door;

    void Update()
    {
        float angle = hinge.angle;

        if (angle < -30f)
        {
            door.SetActive(false);
        }
        else if (angle > 30f)
        {
            door.SetActive(true);
        }
    }

}
