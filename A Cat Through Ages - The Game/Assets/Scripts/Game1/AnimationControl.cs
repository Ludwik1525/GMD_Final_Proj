using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour {
    private float move;
    private Animator anim;
	
	void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        move = Input.GetAxis("Horizontal");
        if (move < 0)
        {
            //anim play left            
            anim.Play("WalkLeft");
            anim.SetBool("isIdle", false);
        }
        if (move > 0)
        {
            //anim play right            
            anim.Play("WalkRight");
            anim.SetBool("isIdle", false);
        }

        if (!Input.anyKey && move == 0)
        {
            anim.Play("Idle");
            anim.SetBool("isIdle", true);
        }
    }
}
