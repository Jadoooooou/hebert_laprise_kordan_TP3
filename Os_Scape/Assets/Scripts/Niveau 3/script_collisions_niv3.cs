using UnityEngine;

public class CratePuzzle_EitherStone : MonoBehaviour
{
    public GameObject stone1;
    public GameObject stone2;
    public GameObject crate;
    public GameObject door;
    public float placementThreshold = 0.5f;

    void Update()
    {
        if (IsOnTop(stone1, crate) || IsOnTop(stone2, crate))
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
