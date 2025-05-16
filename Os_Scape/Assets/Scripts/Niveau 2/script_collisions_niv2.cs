using UnityEngine;

public class CratePuzzle_TwoOutOfThree : MonoBehaviour
{
    public GameObject stone1;
    public GameObject stone2;
    public GameObject stone3;
    public GameObject crate1;
    public GameObject crate2;
    public GameObject door;
    public float placementThreshold = 0.5f;

    void Update()
    {
        bool c1 = IsOnTop(stone1, crate1) || IsOnTop(stone2, crate1) || IsOnTop(stone3, crate1);
        bool c2 = IsOnTop(stone1, crate2) || IsOnTop(stone2, crate2) || IsOnTop(stone3, crate2);

        if (c1 && c2)
        {
            door.SetActive(false);
        }
        else
        {
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
