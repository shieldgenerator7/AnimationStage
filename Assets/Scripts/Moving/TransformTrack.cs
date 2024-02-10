using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[TrackClipType(typeof(RotatorPA))]
[TrackClipType(typeof(MoverPA))]
[TrackBindingType(typeof(Transform))]
public class TransformTrack : TrackAsset
{
    //public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    //{
    //    return ScriptPlayable<RotatorMixerPB>.Create(graph, inputCount);
    //}
}
