using UnityEngine;

public class StoneCollision2 : MonoBehaviour
{
    public GameObject crate2;
    public Animator animPlatform1;

    private bool hasPlayed1 = false;

    void OnCollisionEnter(Collision collision)
    {
        if (!hasPlayed1 && collision.gameObject == crate2)
        {
            if (transform.position.y > crate2.transform.position.y + 0.5f)
            {
                Debug.Log("Stone is on top of the crate!");

                animPlatform1.SetTrigger("PlayAnim1");
            }
        }
    }
}
