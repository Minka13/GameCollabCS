using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroAvailable : MonoBehaviour
{

    public static Gyroscope gyro;
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.gyro.attitude);
        transform.Rotate(Input.gyro.attitude.x, -Input.gyro.attitude.y, 0);
    }
}