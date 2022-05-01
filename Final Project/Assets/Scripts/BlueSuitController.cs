using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSuitController : MonoBehaviour
{

    private Animator animator;
    private CharacterController controller;
    bool attack = false;

    void Start()
    {

        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        float accelerator = 1.0f;

        if (controller.isGrounded)
        {

            if (Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.LeftShift))
            {
                accelerator = 2.0f;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                attack = true;
                animator.SetBool("Attack", attack);
            } else
            {
                attack = false;
                animator.SetBool("Attack", attack);
            }

            float v = Input.GetAxis("Vertical");
            float zSpeed = v * accelerator;

            animator.SetFloat("Speed", zSpeed);
        }
    }
}