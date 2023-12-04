using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            geradeaus();
            transform.Translate(Vector3.forward*2.9);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            links();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            zurück();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rechts();
        }
        else{
            stehen();
        }
    }
    private void geradeaus(){
        animator.SetBool("W", true);
        animator.SetBool("A", false);
        animator.SetBool("S", false);
        animator.SetBool("D", false);
    }
    private void links(){
        animator.SetBool("W", false);
        animator.SetBool("A", true);
        animator.SetBool("S", false);
        animator.SetBool("D", false);
    }
    private void zurück(){
        animator.SetBool("W", false);
        animator.SetBool("A", false);
        animator.SetBool("S", true);
        animator.SetBool("D", false);
    }
    private void rechts(){
        animator.SetBool("W", false);
        animator.SetBool("A", false);
        animator.SetBool("S", false);
        animator.SetBool("D", true);
    }
    private void stehen(){
        animator.SetBool("W", false);
        animator.SetBool("A", false);
        animator.SetBool("S", false);
        animator.SetBool("D", false);
    }
}
