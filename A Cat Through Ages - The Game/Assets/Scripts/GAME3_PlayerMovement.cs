using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GAME3_PlayerMovement : MonoBehaviour {

public float speed;
private Vector2 velocity;
private Rigidbody rb;
    
    void Start()
{
    rb = GetComponent<Rigidbody>();
    }

void Update()
{
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

    velocity = moveInput.normalized * speed * 50;

    Vector3 movement = velocity * Time.fixedDeltaTime;

    rb.MovePosition(rb.position + movement);

    if (!Input.anyKey)
    {
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }
    else
    {
        rb.constraints = RigidbodyConstraints.None;
        rb.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
    }
    }
}

