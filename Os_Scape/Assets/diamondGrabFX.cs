using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class diamondGrabFX : MonoBehaviour
{
    public GameObject portail; 

    private XRGrabInteractable grabInteractable;

    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();

        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.AddListener(OnGrabbed);
        }
    }

    private void OnDestroy()
    {
        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.RemoveListener(OnGrabbed);
        }
    }

    private void OnGrabbed(SelectEnterEventArgs args)
    {
        if (portail != null)
        {
            Debug.Log("WORK BITCH");
            portail.SetActive(true);
        }
    }
}
