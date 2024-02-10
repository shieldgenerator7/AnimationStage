using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Playables;

public class MoverPB : PlayableBehaviour
{
    public Vector3 start;
    //public Vector3 target;
    public float speed = 1;
    public Vector3 dir = Vector2.right;

    //public override void OnBehaviourPlay(Playable playable, FrameData info)
    //{
        
    //}

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        Transform t = playerData as Transform;
        if (!t) { return; }

        float time = (float)playable.GetTime();
        //float duration = (float)playable.GetDuration();
        //t.position = Vector3.Lerp(start, target, time / duration);
        t.position = start + dir * (speed * time);

    }
}
