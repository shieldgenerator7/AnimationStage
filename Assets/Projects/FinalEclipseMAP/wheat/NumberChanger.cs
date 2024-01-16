using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NumberChanger : MonoBehaviour
{
    public float num1;
    public float num2;
    public float loopDuration = 1;

    private float lastBounceTime = 0;
    private bool forward = true;

    public List<StalkSwayer> swayers;

    // Start is called before the first frame update
    void Start()
    {
        if (swayers.Count == 0)
        {
            swayers = GetComponentsInChildren<StalkSwayer>().ToList();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float _num1 = (forward) ? num1 : num2;
        float _num2 = (forward) ? num2 : num1;
        float halfDuration = loopDuration / 2;
        float speed = (_num2 - _num1) / halfDuration;
        float delta = Time.deltaTime;
        float diff = speed * delta;
        float timeDiff = Time.time - lastBounceTime;
        float t = timeDiff / halfDuration;
        foreach (var swayer in swayers)
        {
            swayer.sway = Mathf.Lerp(_num1, _num2, t);
        }
        if (Time.time > lastBounceTime + halfDuration)
        {
            lastBounceTime = Time.time;
            forward = !forward;
        }
    }
}
