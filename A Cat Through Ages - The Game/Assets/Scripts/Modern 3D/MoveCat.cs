using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MoveCat : MonoBehaviour, IMove {

    public Rigidbody rb;

    public float movementSpeed;
    public float rotationSpeed;
    public float rotationDegrees;
    public float runningSpeed;
    public float backwardsSpeed;
    private Animator animator;

    private string dataInJson;

    private MovingSpeed speed;

    void Start()
    {
        speed = new MovingSpeed();
        LoadFile("Assets/Json/config.JSON");


        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        animator.SetBool("run",false);
        animator.SetBool("walk",false);
        animator.SetBool("idle",true);
    }

    void Update()
    {
            Move();
    

        SaveFile("Assets/Json/config.JSON");
        
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

    public void LoadFile(string path)
    {
        dataInJson = File.ReadAllText("Assets/Json/config.JSON");
        speed = JsonUtility.FromJson<MovingSpeed>(dataInJson);

        movementSpeed = speed.movementSpeed;
        rotationSpeed = speed.rotationSpeed;
        rotationDegrees = speed.rotationDegrees;
        runningSpeed = speed.runningSpeed;
        backwardsSpeed = speed.backwardsSpeed;
    }

    public void SaveFile(string path)
    {
        speed.movementSpeed = movementSpeed;
        speed.rotationSpeed = rotationSpeed;
        speed.rotationDegrees = rotationDegrees;
        speed.runningSpeed = runningSpeed;
        speed.backwardsSpeed = backwardsSpeed;

        dataInJson = JsonUtility.ToJson(speed, false);
        File.WriteAllText(path, dataInJson);
    }
}
