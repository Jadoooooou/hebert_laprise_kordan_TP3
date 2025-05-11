using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCollision : MonoBehaviour
{
    public GameObject crate;
    public Animation animPlateform;  // Animation component on the platform

    private bool hasPlayed = false;

    void OnCollisionEnter(Collision collision)
    {
        if (!hasPlayed && collision.gameObject == crate)
        {
            if (transform.position.y > crate.transform.position.y + 0.5f)
            {
                Debug.Log("Stone is on top of the crate!");

                if (animPlateform != null)
                {
                    animPlateform.Play("plateform");  // ? match your clip name exactly
                    hasPlayed = true;
                }
                else
                {
                    Debug.LogWarning("Animation component not assigned to animPlateform!");
                }
            }
        }
    }
}