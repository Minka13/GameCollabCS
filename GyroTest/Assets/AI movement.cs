using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AImovement : MonoBehaviour
{
    public NavMeshAgent agent1;
    public Vector3 vector3_1;


    public void Update()
    {
        vector3_1 = new Vector3(0, 0.22f, -6.77f);
        agent1.SetDestination(vector3_1);
    }
}
