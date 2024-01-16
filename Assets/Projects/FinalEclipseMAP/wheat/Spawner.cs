using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int rowCount = 5;
    public int columnCount = 10;
    public float columnOffset = 1;

    public GameObject prefab;

    public BoxCollider2D bc2d;

    // Start is called before the first frame update
    void Awake()
    {
        float xSpace = bc2d.bounds.size.x / columnCount;
        float ySpace = bc2d.bounds.size.y / rowCount;
        Vector2 origin = bc2d.bounds.min;
        for (int x = 0; x < columnCount; x++)
        {
            for (int y = 0; y < rowCount; y++)
            {
                Vector2 pos = new Vector2(
                    (x * xSpace) + (columnOffset * y),
                    y * ySpace
                    ) + origin;
                GameObject go = Instantiate(prefab, transform);
                go.transform.position = pos;

            }
        }
        //
        GetComponent<NumberChanger>()?.Start();
    }
}
