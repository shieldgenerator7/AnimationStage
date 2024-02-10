using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MoverPA : PlayableAsset
{
    public ExposedReference<Transform> erTarget;
    public MoverPB template;

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var spmover = ScriptPlayable<MoverPB>.Create(graph, template);
        var mover = spmover.GetBehaviour();
        Transform t = graph.GetOutput(0).GetUserData() as Transform;
        mover.start = t.position;
        Transform target = erTarget.Resolve(graph.GetResolver());
        //mover.target = target.position;
        mover.dir = (target.position - t.position).normalized;
        return spmover;
    }
}
