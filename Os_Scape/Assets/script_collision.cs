using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StoneCollision : MonoBehaviour
{
    public GameObject crate;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == crate)
        {
            if (transform.position.y > crate.transform.position.y + 0.5f)
            {
                Debug.Log("Stone is on top of the crate!");
            }
        }
    }
}

