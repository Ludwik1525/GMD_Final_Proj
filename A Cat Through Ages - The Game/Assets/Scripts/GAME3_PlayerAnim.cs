using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAME3_PlayerAnim : MonoBehaviour {

    [HideInInspector]
    public Animator anim;

    private AudioSource source;

    public AudioClip walkingSound;

    private bool isSoundPlaying = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            PlaySound(walkingSound);
            anim.Play("GAME3-CatUp");
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            PlaySound(walkingSound);
            anim.Play("GAME3-CatDown");
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            PlaySound(walkingSound);
            anim.Play("GAME3-CatLeft");
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            PlaySound(walkingSound);
            anim.Play("GAME3-CatRight");
        }

        if (!Input.anyKey)
        {
            anim.Play("GAME3-CatIdle");
            source.Stop();
            isSoundPlaying = false;
        }

    }


    void PlaySound(AudioClip clip)
    {
        if (!isSoundPlaying)
        {
            source.loop = true;
            source.clip = clip;
            source.Play();
            isSoundPlaying = true;
        }
    }
}
