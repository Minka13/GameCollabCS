using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(UnityEngine.Timeline.SignalReceiver))]

public class CutSceneStart : Interactable
{
    [SerializeField] private GameObject cutsceneToPlay;


    public override void Activate()
    {
        base.Activate();
    }

    public override void Deactivate()
    {
        base.Deactivate();
    }
}
