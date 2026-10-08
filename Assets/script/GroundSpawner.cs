using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundPrefab;

    // 使用 Array 儲存地塊位置
    public Vector2[] blockPositions =
    {
        new Vector2(-4f, -3f),
        new Vector2(-3f, -3f),
        new Vector2(-2f, -3f),
        new Vector2(-1f, -3f),
        new Vector2(0f, -3f),
        new Vector2(1f, -3f),

        new Vector2(3f, -1f),
        new Vector2(4f, -1f),
        new Vector2(5f, -1f),
        new Vector2(6f, -1f),

        new Vector2(8f, 1f),
        new Vector2(9f, 1f),
        new Vector2(10f, 1f),
        new Vector2(11f, 1f)
    };

    void Start()
    {
        for (int i = 0; i < blockPositions.Length; i++)
        {
            Instantiate(groundPrefab, blockPositions[i], Quaternion.identity);
        }
    }
}