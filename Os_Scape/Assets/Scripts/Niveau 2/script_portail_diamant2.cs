using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

public class DiamondPortalTrigger2 : MonoBehaviour
{
    public GameObject diamond;
    public GameObject FX;
    public float delay = 5f;
    public float placementHeightThreshold = 0.5f;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == diamond)
        {
            if (diamond.transform.position.z > transform.position.z)
            {

                if (diamond.transform.position.y > transform.position.y + placementHeightThreshold)
                {
                    FX.SetActive(true);
                    StartCoroutine(NextLevel());
                }
            }
        }
    }

    IEnumerator NextLevel()

    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("Niveau3");
    }
}