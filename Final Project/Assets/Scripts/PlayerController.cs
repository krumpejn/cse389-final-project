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

        if (!controller.isGrounded) return;

        if (Input.GetKey(KeyCode.Space))
            animator.SetBool("Attack", true);

        else
            animator.SetBool("Attack", false);

        float v = Input.GetAxis("Vertical");
        float zSpeed = v * accelerator;
        animator.SetFloat("Speed", zSpeed);
    }
}