using UnityEngine;

public class StoneCollision : MonoBehaviour
{
    public GameObject crate;
    public Animator animPlatform;

    private bool isStoneOnCrate = false;

    void Update()
    {
        if (isStoneOnCrate)
        {
            if (transform.position.y <= crate.transform.position.y + 0.5f)
            {
                Debug.Log("Stone is no longer on top of the crate.");
                animPlatform.SetTrigger("CloseAnim");
                isStoneOnCrate = false; 
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == crate)
        {
            if (transform.position.y > crate.transform.position.y + 0.5f && !isStoneOnCrate)
            {
                Debug.Log("Stone is on top of the crate!");

                animPlatform.SetTrigger("PlayAnim");
                isStoneOnCrate = true; 
            }
        }
    }
}
