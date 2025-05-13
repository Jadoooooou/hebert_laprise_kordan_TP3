using UnityEngine;

public class StoneCollision3 : MonoBehaviour
{
    public GameObject crate1;
    public GameObject crate2;
    public GameObject door;

    private bool stoneOnCrate1 = false;
    private bool stoneOnCrate2 = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == crate1)
        {
            if (transform.position.y > crate1.transform.position.y + 0.5f)
            {
                Debug.Log("Stone is on top of crate1!");
                stoneOnCrate1 = true;
                CheckCrates();
            }
        }
        else if (collision.gameObject == crate2)
        {
            if (transform.position.y > crate2.transform.position.y + 0.5f)
            {
                Debug.Log("Stone is on top of crate2!");
                stoneOnCrate2 = true;
                CheckCrates();
            }
        }
    }

    void CheckCrates()
    {
        if (stoneOnCrate1 && stoneOnCrate2)
        {
            Debug.Log("Both crates have stones! Door is deactivated.");
            door.SetActive(false);
        }
    }
}