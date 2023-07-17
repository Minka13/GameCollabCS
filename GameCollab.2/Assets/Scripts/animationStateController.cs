using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");


    }

    // Update is called once per frame
    void Update()
    {

        bool isWalking = animator.GetBool(isWalkingHash);

        bool isSprinting = animator.GetBool("isSprinting");

        bool forwardPressed = Input.GetKey("w") | Input.GetKey("s") | Input.GetKey("a") | Input.GetKey("d");

        bool JumpPressed = Input.GetKey("space");

        bool SprintPressed = Input.GetKey("left shift");

        if (!isWalking && forwardPressed && !JumpPressed)
        {
            animator.SetBool(isWalkingHash, true);
        }
        if(JumpPressed)
        {
            animator.SetBool("isJumping", true);
        }
        if(!JumpPressed)
        {
            animator.SetBool("isJumping", false);
        }
        if (isWalking && !forwardPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }
        if(!isSprinting && (forwardPressed && SprintPressed))
        {
            animator.SetBool("isSprinting", true);
        }
        if(isSprinting && (!forwardPressed || !SprintPressed))
        {
            animator.SetBool("isSprinting", false);
        }
    }
}
