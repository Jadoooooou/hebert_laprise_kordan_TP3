using UnityEngine;
// using UnityEngine.SceneManagement; // Commented out to disable scene change

public class DiamondPortalTrigger : MonoBehaviour
{
    public GameObject diamond;               // Assign the diamond in Inspector
    public float placementHeightThreshold = 0.5f;

    private bool messageDisplayed = false;

    void OnTriggerEnter(Collider other)
    {
        if (!messageDisplayed && other.gameObject == diamond)
        {
            // Ensure diamond is resting on or near the portal (optional height check)
            if (diamond.transform.position.y > transform.position.y + placementHeightThreshold)
            {
                Debug.Log("Diamond placed on portal — message triggered.");
                messageDisplayed = true;

                // --- Scene change (commented out for now) ---
                // StartCoroutine(LoadSceneWithDelay(1.0f)); // Uncomment to load scene

                // --- Optional: delay before message, if needed ---
                // StartCoroutine(ShowMessageWithDelay(1.0f));
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
        Debug.Log("Diamond placed on portal — message triggered with delay.");
    }
    */
}
