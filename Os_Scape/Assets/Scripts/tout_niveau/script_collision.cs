using UnityEngine;

public class StoneCollision : MonoBehaviour
{
    public GameObject crate;
    public Animator animPlatform; 

    private bool hasPlayed = false;

    void OnCollisionEnter(Collision collision)
    {
        if (!hasPlayed && collision.gameObject == crate)
        {
            if (transform.position.y > crate.transform.position.y + 0.5f)
            {
                Debug.Log("Stone is on top of the crate!");

                animPlatform.SetTrigger("PlayAnim"); 
            }
        }
    }
}
