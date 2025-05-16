using System.Collections;
using extOSC;
using UnityEngine;

public class PuzzleDoorController : MonoBehaviour
{
    public OSCReceiver oscReceiver;

    public GameObject door1_Left;
    public GameObject door1_Right;

    public GameObject door2;      
    public GameObject finalDoor;  

    public GameObject door3_Left;
    public GameObject door3_Right;

    private float slider1Value;
    private float slider2Value;
    private float slider3Value;

    void Start()
    {
        oscReceiver.Bind("/slider_lever1", msg => slider1Value = ExtractValue(msg));
        oscReceiver.Bind("/slider_lever2", msg => slider2Value = ExtractValue(msg));
        oscReceiver.Bind("/slider_lever3", msg => slider3Value = ExtractValue(msg));
    }

    void Update()
    {
        door1_Left?.SetActive(slider1Value < 0);
        door1_Right?.SetActive(slider1Value > 0);

        if (door2 != null)
            door2.SetActive(slider2Value < 0);      

        if (finalDoor != null)
            finalDoor.SetActive(slider2Value > 0);    

        door3_Left?.SetActive(slider3Value < 0);
        door3_Right?.SetActive(slider3Value > 0);
    }

    float ExtractValue(OSCMessage msg)
    {
        if (msg.Values.Count > 0)
        {
            return msg.Values[0].Type switch
            {
                OSCValueType.Float => msg.Values[0].FloatValue,
                OSCValueType.Int => msg.Values[0].IntValue,
                _ => 0f
            };
        }
        return 0f;
    }
}
