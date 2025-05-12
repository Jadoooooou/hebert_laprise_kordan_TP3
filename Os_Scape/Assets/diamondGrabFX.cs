using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamondGrabFX : MonoBehaviour
{
    public GameObject portail; 

    private void OnTriggerEnter(Collider diamant)
    {
        Debug.Log("Something entered: ");

        if (diamant.CompareTag("diamantCollect"))
        {
            Debug.Log("Diamond detected!");
            portail.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider diamant)
    {
        if (diamant.CompareTag("diamantCollect"))
        {
            portail.SetActive(false);
        }
    }

}
