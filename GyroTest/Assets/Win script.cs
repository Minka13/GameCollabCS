using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winscript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision begun");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collision stayed");
    }


    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision exited");
    }
}
