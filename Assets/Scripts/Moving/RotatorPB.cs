using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[System.Serializable]
public class RotatorPB : PlayableBehaviour
{
    public float speed = 100;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        Transform t = playerData as Transform;
        if (!t) { return; }
        Vector3 euler = t.eulerAngles;
        euler.z += speed * info.deltaTime;
        t.eulerAngles = euler;
    }
}
