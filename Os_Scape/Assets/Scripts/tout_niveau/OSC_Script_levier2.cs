using System.Collections;
using System.Collections.Generic;
using extOSC;
using UnityEngine;

public class OSCScript_levier2 : MonoBehaviour
{
    public OSCReceiver oscReceiver;
    public OSCTransmitter oscTransmitter;

    public GameObject handleObject;           // GameObject with the HingeJoint
    private HingeJoint hinge;

    private float myChrono;
    private int maValeur;
    public float valueX;                      // OSC input
    public float motorForce = 50f;
    public float motorSpeedMultiplier = 100f;

    void Start()
    {
        if (handleObject != null)
        {
            hinge = handleObject.GetComponent<HingeJoint>();
            if (hinge == null)
            {
                Debug.LogError("HingeJoint not found on handleObject.");
            }
        }

        oscReceiver.Bind("/slider_lever2", TraiterX);
    }

    void LateUpdate()
    {
        if (hinge != null)
        {
            JointMotor motor = hinge.motor;
            motor.force = motorForce;
            motor.targetVelocity = valueX * motorSpeedMultiplier;
            hinge.motor = motor;
            hinge.useMotor = true;

            valueX = 0f; // Reset if you're using OSC events rather than continuous stream
        }

        // Send OSC response every 0.1s
        if (Time.realtimeSinceStartup - myChrono >= 0.1f)
        {
            myChrono = Time.realtimeSinceStartup;

            var myOscMessage = new OSCMessage("/adresse");
            myOscMessage.AddValue(OSCValue.Int(maValeur));
            oscTransmitter.Send(myOscMessage);
        }
    }

    public void TraiterX(OSCMessage oscMessage)
    {
        if (oscMessage.Values.Count > 0)
        {
            if (oscMessage.Values[0].Type == OSCValueType.Float)
                valueX = oscMessage.Values[0].FloatValue;
            else if (oscMessage.Values[0].Type == OSCValueType.Int)
                valueX = oscMessage.Values[0].IntValue;

            Debug.Log($"Received X: {valueX}");
        }
    }
}
