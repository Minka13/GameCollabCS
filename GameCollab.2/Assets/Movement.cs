using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody rb;
    public GameObject Player;


    private void Update();
    {
        

        Vector3 = new Vector3 (Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        transform.position.player = transform.position.player + Vector3 * 5f;

    }
}

