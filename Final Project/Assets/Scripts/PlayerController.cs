using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Animator animator;
    private CharacterController controller;

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
            if (Input.GetKey(KeyCode.RightShift))
                animator.SetBool("Attack", true);
            else
                animator.SetBool("Attack", false);
            if (Input.GetKey(KeyCode.Space))
                animator.SetBool("Jump", true);
            else
                animator.SetBool("Jump", false);
            float v = Input.GetAxis("Vertical");
            float zSpeed = v * accelerator;
            animator.SetFloat("Speed", zSpeed);
        }
    }
}