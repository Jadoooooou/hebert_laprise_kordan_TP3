using UnityEngine;

public class PlatformParenting1 : MonoBehaviour
{
    public GameObject empty;   // Neutral object to unparent to

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.parent = transform.parent; // Set player as child of the platform
            Debug.Log("Player entered platform trigger. Player is now child of: " + transform.parent.name);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.parent = empty.transform; // Unparent to empty
            Debug.Log("Player exited platform trigger. Player is now child of: " + empty.name);
        }
    }
}
