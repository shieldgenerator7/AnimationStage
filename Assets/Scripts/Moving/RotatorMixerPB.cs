using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class RotatorMixerPB : PlayableBehaviour
{
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        Transform t = playerData as Transform;
        if (!t) { return; }

        float finalSpeed = 0;

        //2024-02-09: copied from https://blog.unity.com/engine-platform/extending-timeline-practical-guide
        int inputCount = playable.GetInputCount(); //get the number of all clips on this track

        for (int i = 0; i < inputCount; i++)
        {
            float inputWeight = playable.GetInputWeight(i);
            RotatorPB input = ((ScriptPlayable<RotatorPB>)playable.GetInput(i)).GetBehaviour();

            // Use the above variables to process each frame of this playable.
            finalSpeed += input.speed * inputWeight;
        }

        //assign the result to the bound object
        Vector3 euler = t.eulerAngles;
        euler.z += finalSpeed * info.deltaTime;
        t.eulerAngles = euler;

    }
}
