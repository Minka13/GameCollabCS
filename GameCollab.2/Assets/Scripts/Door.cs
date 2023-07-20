using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door: MonoBehaviour
{
    public Animation hingehere;
    public Component door;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
            hingehere.Play();

        if (Input.GetKey(KeyCode.E))
            door.GetComponent<BoxCollider>().enabled = false;


    }
}