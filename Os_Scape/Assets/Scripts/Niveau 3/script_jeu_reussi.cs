using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiamondPortalTrigger3 : MonoBehaviour
{
    public GameObject diamond;
    public GameObject FX;
    public GameObject Reussite;
    public float sceneLoadDelay = 5f;
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
                    Reussite.SetActive(true);
                    StartCoroutine(LoadMenuAfterDelay());
                }
            }
        }
    }

    IEnumerator LoadMenuAfterDelay()
    {
        yield return new WaitForSeconds(sceneLoadDelay);
        SceneManager.LoadScene("Menu");
    }
}
