using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneOrigin : MonoBehaviour
{
    [SerializeField] private CanvasGroup interactableUI;

    private void Start()
    {
        LeanTween.alphaCanvas(interactableUI, to: 1, time: 8);
    }
}
