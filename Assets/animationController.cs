using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool forwardPress = Input.GetKey("w");
       // if you press w it will play the walking animation
        if (forwardPress)
        {
            // then set the "isWalking" bool to be true
            animator.SetBool("isWalking", true);
        }

       // if player is not pressing w no walking anitmation
        if (!forwardPress)
        {
            // then set the "isWalking" bool to be false
            animator.SetBool("isWalking", false);
        }
    }
}
