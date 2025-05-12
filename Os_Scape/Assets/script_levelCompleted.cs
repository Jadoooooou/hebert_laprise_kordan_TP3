using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Needed to change scenes

public class NewBehaviourScript : MonoBehaviour
{
    public int count = 0; // Tracks diamonds collected

    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Trigger hit: {other.name}  (tag: {other.tag})");

        if (other.CompareTag("diamant"))
        {
            Debug.Log("Diamond collected!");
            other.gameObject.SetActive(false);
            count++;
        }

        if (other.CompareTag("portal") && count > 0)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
