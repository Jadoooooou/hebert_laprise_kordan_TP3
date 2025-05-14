using UnityEngine;

public class PlatformParenting1 : MonoBehaviour
{
    public GameObject joueur;          // Reference to the player
    public GameObject empty;           // Neutral object to unparent to

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == joueur)
        {
            joueur.transform.parent = transform.parent; // Set player as child of the platform
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == joueur)
        {
            joueur.transform.parent = empty.transform; // Unparent to empty
        }
    }
}
