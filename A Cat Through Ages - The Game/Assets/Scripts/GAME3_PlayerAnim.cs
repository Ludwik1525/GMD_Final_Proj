using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAME3_PlayerAnim : MonoBehaviour {

    [HideInInspector]
    public Animator anim;

    private AudioSource source;

    private AudioClip walkingSound;

    private bool isSoundPlaying = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            anim.Play("GAME3-CatUp");
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            anim.Play("GAME3-CatDown");
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            anim.Play("GAME3-CatLeft");
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.Play("GAME3-CatRight");
        }

        if (!Input.anyKey)
        {
            anim.Play("GAME3-CatIdle");
        }

    }
}
