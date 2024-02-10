using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class RotatorPA : PlayableAsset
{
    public RotatorPB template;

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        return ScriptPlayable<RotatorPB>.Create(graph, template);
    }
}
