using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementGame1 : MonoBehaviour
{

    [SerializeField]
    private float speed, move;
    [SerializeField]
    private Rigidbody2D playerRgbd;
    public float jumpVelocity;
    private SpriteRenderer playerSprite;
    private Vector2 MovementInput;
    private bool Grounded = false;    

    public void Awake()
    {
        playerRgbd = gameObject.GetComponent<Rigidbody2D>();
        
        playerSprite = GetComponent<SpriteRenderer>();
    }


    public void FixedUpdate()
    {
        
            move = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && Grounded)
        {
            playerRgbd.velocity = Vector2.up * jumpVelocity;
        }
        else
        Move();
        
    }


    public void Move()
    {
        
        MovementInput = MovementInput.normalized * speed;
        //no need for time.deltatime because of fixedupdate
        
        playerRgbd.velocity = new Vector2(move * speed, GetComponent<Rigidbody2D>().velocity.y);
    }



    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.collider.gameObject.tag == "Ground")
        {
            Grounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {

        if (other.collider.gameObject.tag == "Ground")
        {
            Grounded = false;

        }
    }

}
