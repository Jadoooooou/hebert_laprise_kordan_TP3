using UnityEngine;

public class DualStoneCratePuzzle : MonoBehaviour
{
    public GameObject stone1;
    public GameObject stone2;
    public GameObject crate1;
    public GameObject crate2;
    public Animator animPlateform;

    public float placementThreshold = 0.5f; // How high stone needs to be above crate

    private bool stone1OnCrate = false;
    private bool stone2OnCrate = false;

    void Update()
    {
        stone1OnCrate = IsOnTop(stone1, crate1);
        stone2OnCrate = IsOnTop(stone2, crate2);

        if (stone1OnCrate && stone2OnCrate)
        {
            animPlateform.SetTrigger("PlayAnim");
            Debug.Log("Both stones are on crates. Playing animation.");
        }
        else
        {
            animPlateform.SetTrigger("Idle");
            Debug.Log("One or both stones are not on crates. Returning to idle.");
        }
    }

    bool IsOnTop(GameObject stone, GameObject crate)
    {
        float verticalOffset = stone.transform.position.y - crate.transform.position.y;

        float horizontalDistance = Vector3.Distance(
            new Vector3(stone.transform.position.x, 0, stone.transform.position.z),
            new Vector3(crate.transform.position.x, 0, crate.transform.position.z)
        );

        return verticalOffset > placementThreshold && horizontalDistance < 0.5f;
    }
}
