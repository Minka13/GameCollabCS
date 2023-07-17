using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    [SerializeField] private CanvasGroup interactableUI;

    private bool playerWithinRange;


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            playerWithinRange = true;

            interactableUI.gameObject.SetActive(true);
            LeanTween.cancel(interactableUI.gameObject);
            LeanTween.alphaCanvas(interactableUI, to: 1, time: 1);


        }
    }

    private void Update()
    {
        if (playerWithinRange && Input.GetKeyUp(KeyCode.E))
        {
            Activate();
        }
    }

    public virtual void Activate()
    {
        interactableUI.gameObject.SetActive(false);
    }

    public virtual void Deactivate()
    {
        
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            playerWithinRange = false;

            LeanTween.alphaCanvas(interactableUI, to: 0, time: 1)
                .setOnComplete(UIHide());

        }

    }

    private object UIHide()
    {
        throw new NotImplementedException();
    }
}
