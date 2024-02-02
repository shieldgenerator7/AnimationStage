using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2024-02-02: copied from GGJ2024 (Mr. Unlucky)

public class Rotation : MonoBehaviour
{
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        Vector3 euler = transform.eulerAngles;
        euler.z += speed * Time.deltaTime;
        transform.eulerAngles = euler;
    }
}
