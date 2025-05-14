using UnityEngine;

public class CratePuzzleManager : MonoBehaviour
{
    public GameObject[] stones;
    public GameObject crate1;
    public GameObject crate2;
    public GameObject door;
    public float placementThreshold = 0.5f;

    private bool crate1Occupied = false;
    private bool crate2Occupied = false;

    void Update()
    {
        crate1Occupied = false;
        crate2Occupied = false;

        foreach (GameObject stone in stones)
        {
            if (IsOnTop(stone, crate1)) crate1Occupied = true;
            if (IsOnTop(stone, crate2)) crate2Occupied = true;
        }

        // Open door if both crates are occupied
        if (crate1Occupied && crate2Occupied)
        {
            Debug.Log("Both crates are occupied. Opening door.");
            door.SetActive(false);
        }
        // Close door if either crate is not occupied
        else if (!crate1Occupied || !crate2Occupied)
        {
            Debug.Log("One or both crates are not occupied. Closing door.");
            door.SetActive(true);
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
