using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    public Animator animator;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (animator.GetBool("isRotating")))
        {
            animator.SetBool("isRotating", false);
        }

        else if (Input.GetKeyDown(KeyCode.Space) && (!animator.GetBool("isRotating")))
        {
            animator.SetBool("isRotating", true);
        }
    }
}