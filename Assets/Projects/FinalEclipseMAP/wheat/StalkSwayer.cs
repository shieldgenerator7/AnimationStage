using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalkSwayer : MonoBehaviour
{
    public float sway = 0;
    public float stalkLength = 1;

    public List<GameObject> stalks;

    private float prevSway = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (sway == prevSway)
        {
            return;
        }
        prevSway = sway;
        Vector3 dirPos = stalks[0].transform.position;
        float scaleY = transform.localScale.y;
        for (int i = 0; i < stalks.Count; i++)
        {
            GameObject stalk = stalks[i];
            //
            stalk.transform.position = dirPos;
            //
            Vector3 euler = stalk.transform.eulerAngles;
            euler.z = sway * (1 + i);
            stalk.transform.eulerAngles = euler;
            //
            dirPos = stalk.transform.position
                + stalk.transform.TransformDirection(
                    Vector2.up * stalkLength * scaleY
                    );
        }
    }
}
