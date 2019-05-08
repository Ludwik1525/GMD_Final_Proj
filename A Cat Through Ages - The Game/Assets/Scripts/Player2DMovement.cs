using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2DMovement : MonoBehaviour {

    [SerializeField] public float moveSpeed, jumpHeight;
    [SerializeField] private Vector2 movement;
    [SerializeField] private float moveHorizontal;

    private Rigidbody2D player;
    private Vector3 m_Velocity = Vector3.zero;
    public bool isGrounded = true;
//    public bool keyFunctionOpen;

 //   public AudioSource source;
 //   public AudioClip jump;


    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        jumpHeight = 10f;
    }

    void FixedUpdate()
    {

 //       if (keyFunctionOpen)
        {
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                player.AddForce(new Vector2(0f, jumpHeight));
 //               source.PlayOneShot(jump);
            }

            Vector3 targetVelocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed * Time.fixedDeltaTime * 10f,
                player.velocity.y);
            player.velocity = Vector3.SmoothDamp(player.velocity, targetVelocity, ref m_Velocity, 0.05f);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Player")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Player")
        {
            isGrounded = false;
        }
    }
}
