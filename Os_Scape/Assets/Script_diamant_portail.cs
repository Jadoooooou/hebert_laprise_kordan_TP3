using UnityEngine;
// using UnityEngine.SceneManagement; // Commented out to disable scene change

public class DiamondPortalTrigger : MonoBehaviour
{
    public GameObject diamond;
    public GameObject FX;
    public float placementHeightThreshold = 0.5f;  // Optional height threshold

    private bool messageDisplayed = false;

    void OnTriggerEnter(Collider other)
    {
        if (!messageDisplayed && other.gameObject == diamond)
        {
            // Check if the diamond is in front of the portal on the Z-axis
            if (diamond.transform.position.z > transform.position.z) // Positive Z = in front of portal
            {
                // Ensure the diamond is resting on or near the portal (optional height check)
                if (diamond.transform.position.y > transform.position.y + placementHeightThreshold)
                {
                    Debug.Log("Diamond placed in front of portal — message triggered.");
                    FX.SetActive(true);
                    messageDisplayed = true;

                    // --- Scene change (commented out for now) ---
                    // StartCoroutine(LoadSceneWithDelay(1.0f)); // Uncomment to load scene

                    // --- Optional: delay before message, if needed ---
                    // StartCoroutine(ShowMessageWithDelay(1.0f));
                }
            }
        }
    }

    // Uncomment the method below if you'd like to trigger a scene change with a delay
    /*
    IEnumerator LoadSceneWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("NextScene");  // Replace "NextScene" with your actual scene name
    }
    */

    // Uncomment this if you want to delay the message print
    /*
    IEnumerator ShowMessageWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("Diamond placed in front of portal — message triggered with delay.");
    }
    */
}
