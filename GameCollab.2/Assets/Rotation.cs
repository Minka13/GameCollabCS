using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            transform.Rotate(40f, 0, 0);

        }

    }
}