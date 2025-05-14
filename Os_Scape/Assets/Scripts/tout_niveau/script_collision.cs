using UnityEngine;

public class StoneCollision : MonoBehaviour
{
    public GameObject crate;
    public Animator animPlateform;

    private bool isTouchingCrate = false;
    private bool isStoneOnCrate = false;

    public float heightThreshold = 0.5f;  // How much higher the stone must be above the crate

    void Update()
    {
        if (isTouchingCrate)
        {
            // Check if the stone is truly on top
            if (transform.position.y > crate.transform.position.y + heightThreshold)
            {
                if (!isStoneOnCrate)
                {
                    Debug.Log("Stone is now on top of the crate.");
                    animPlateform.SetTrigger("PlayAnim");
                    isStoneOnCrate = true;
                }
            }
            else
            {
                // Still touching, but no longer on top
                if (isStoneOnCrate)
                {
                    Debug.Log("Stone fell off the crate.");
                    animPlateform.SetTrigger("Idle");
                    isStoneOnCrate = false;
                }
            }
        }
        else if (isStoneOnCrate)
        {
            // No longer touching at all
            Debug.Log("Stone is no longer touching the crate.");
            animPlateform.SetTrigger("Idle");
            isStoneOnCrate = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == crate)
        {
            isTouchingCrate = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == crate)
        {
            isTouchingCrate = false;
        }
    }
}
