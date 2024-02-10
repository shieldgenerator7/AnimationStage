using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class RotatorPA : PlayableAsset, IPropertyPreview
{
    [SerializeField]
    public RotatorPB template;

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        return ScriptPlayable<RotatorPB>.Create(graph, template);
    }

    public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
    {
        //2024-02-09: copied from https://forum.unity.com/threads/how-to-make-custom-playables-reset-to-previous-state-after-preview.666892/#post-4464763
        
        //const string kLocalPosition = "m_LocalPosition";
        //driver.AddFromName<Transform>(kLocalPosition + ".x");
        //driver.AddFromName<Transform>(kLocalPosition + ".y");
        //driver.AddFromName<Transform>(kLocalPosition + ".z");

        const string kLocalRotation = "m_LocalRotation";
        //driver.AddFromName<Transform>(kLocalRotation + ".x");
        //driver.AddFromName<Transform>(kLocalRotation + ".y");
        driver.AddFromName<Transform>(kLocalRotation + ".z");
        //driver.AddFromName<Transform>(kLocalRotation + ".w");
    }
}
