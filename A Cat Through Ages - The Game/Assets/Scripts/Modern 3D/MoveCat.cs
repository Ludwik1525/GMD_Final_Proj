using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MoveCat : MonoBehaviour, IMove {

    public Rigidbody rb;

    public float movementSpeed = 0.2f;
    public float rotationSpeed = 1f;
    public float rotationDegrees = 90f;
    public float runningSpeed = 0.5f;
    public float backwardsSpeed = 0.2f;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        animator.SetBool("run",false);
        animator.SetBool("walk",false);
        animator.SetBool("idle",true);
    }

    void Update()
    {
            Move();
        
    }

    public void Move()
    {
            if (Input.GetKey(KeyCode.W))
            {
                animator.SetBool("idle",false);
                animator.SetBool("walk",true);
                animator.SetBool("run",false);

                //moving forward and rotating to the left simultaneously
                if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
                {
                    if (Input.GetKey(KeyCode.Space))
                    {
                        rb.position += transform.forward * Time.deltaTime * runningSpeed;
                        animator.SetBool("run",true);
                        animator.SetBool("walk", false);
                }
                    else
                    {
                        rb.position += transform.forward * Time.deltaTime * movementSpeed;
                        rb.transform.Rotate(0f, -(rotationDegrees) * Time.deltaTime * rotationSpeed, 0f);
                    }
                }

                //moving forward and rotating to the right simultaneously
                else if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
                {
                    if (Input.GetKey(KeyCode.Space))
                    {
                        rb.position += transform.forward * Time.deltaTime * runningSpeed;
                        animator.SetBool("run",true);
                        animator.SetBool("walk", false);
                }
                    else
                    {
                        rb.position += transform.forward * Time.deltaTime * movementSpeed;
                        rb.transform.Rotate(0f, rotationDegrees * Time.deltaTime * rotationSpeed, 0f);
                    }
                }
                //moving forward
                else if (Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
                {
                   
                        rb.position += transform.forward * Time.deltaTime * runningSpeed;
                        animator.SetBool("run",true);
                        animator.SetBool("walk", false);

            }
                else
                {
                    rb.position += transform.forward * Time.deltaTime * movementSpeed;
                }
            }

            else if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.Space))
            {
                animator.SetBool("idle", false);
                animator.SetBool("walk", true);
                animator.SetBool("run", false);

                //moving backwards and rotating to the left simultaneously
                if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
                {
                    rb.position -= transform.forward * Time.deltaTime * backwardsSpeed;
                    rb.transform.Rotate(0f, -(rotationDegrees) * Time.deltaTime * rotationSpeed, 0f);
                }

                //moving backwards and rotating to the right simultaneously
                else if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
                {
                    rb.position -= transform.forward * Time.deltaTime * backwardsSpeed;
                    rb.transform.Rotate(0f, rotationDegrees * Time.deltaTime * rotationSpeed, 0f);
                }

                //moving backwards
                else
                {
                    rb.position -= transform.forward * Time.deltaTime * backwardsSpeed;
                }
            }
            //turning around
            else
            {
                animator.SetBool("idle", true);
                animator.SetBool("walk", false);
                animator.SetBool("run", false);

            if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S))
                {
                    rb.transform.Rotate(0f, -(rotationDegrees) * Time.deltaTime * rotationSpeed, 0f);
                }

                if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S))
                {
                    rb.transform.Rotate(0f, rotationDegrees * Time.deltaTime * rotationSpeed, 0f);
                }

                
            }
        
    }

  
}
