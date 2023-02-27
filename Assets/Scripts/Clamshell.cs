using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clamshell : MonoBehaviour
{

    public Animator animator;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("Open");            
        }
    }
}
