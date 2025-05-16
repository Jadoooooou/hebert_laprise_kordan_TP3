using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_interactions_nv3 : MonoBehaviour
{
    public HingeJoint hinge1, hinge2, hinge3, hinge4;

    public GameObject porte1Gauche, porte1Droite;
    public GameObject porte2;
    public GameObject porte3Gauche, porte3Droite;
    public GameObject porte4;
    public GameObject porte02;
    public GameObject porte03;

    public float angleThreshold = 10f; 

    private float closeTimer = 0f;
    private bool shouldClosePorte1Droite = false;

    void Update()
    {
        float angle1 = hinge1.angle;
        float angle2 = hinge2.angle;
        float angle3 = hinge3.angle;
        float angle4 = hinge4.angle;

        //porte 1
        if (Mathf.Abs(angle1 - angle2) > angleThreshold)
        {
            SetDoorState(porte1Droite, true);
            SetDoorState(porte1Gauche, false);
            shouldClosePorte1Droite = false;
            closeTimer = 0f;
        }
        else
        {
            if (!shouldClosePorte1Droite)
            {
                shouldClosePorte1Droite = true;
                closeTimer = Time.time + 1.5f;
            }

            if (shouldClosePorte1Droite && Time.time > closeTimer)
            {
                SetDoorState(porte1Droite, false);
                SetDoorState(porte1Gauche, true);
            }
        }

        //porte 2
        if (angle2 > 30f)
            SetDoorState(porte2, true);
        else if (angle2 < -30f)
            SetDoorState(porte2, false);

        //porte 3
        if (angle3 < -30f)
        {
            SetDoorState(porte3Gauche, true);
            SetDoorState(porte3Droite, false);
        }
        else if (angle3 > 30f)
        {
            SetDoorState(porte3Gauche, false);
            SetDoorState(porte3Droite, true);
        }

        //porte 4
        float diff34 = Mathf.Abs(angle3 - angle4);
        if (diff34 > angleThreshold)
        {
            Debug.Log($"[Porte4] OPEN — angle3: {angle3}, angle4: {angle4}, diff: {diff34}");
            SetDoorState(porte4, true);
        }
        else
        {
            Debug.Log($"[Porte4] CLOSED — angle3: {angle3}, angle4: {angle4}, diff: {diff34}");
            SetDoorState(porte4, false);
        }
    }

    void SetDoorState(GameObject door, bool state)
    {
        if (door == null) return;

        if (door.activeSelf != state)
            door.SetActive(state);

        var col = door.GetComponent<BoxCollider>();
        if (col != null && col.enabled != state)
            col.enabled = state;

        var rend = door.GetComponent<MeshRenderer>();
        if (rend != null && rend.enabled != state)
            rend.enabled = state;
    }
}
