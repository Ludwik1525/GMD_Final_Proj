using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public AudioSource sound;
    public AudioClip idleClip,deathClip;
    private Animator anim;
	// Use this for initialization
	void Start () {
        sound = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        GetComponent<StandardHealth>().OnDied += DeathSound;
        
	}
	
	// Update is called once per frame
	void Update () {
        while(anim.GetBool("isIdle"))
        {
            sound.PlayOneShot(idleClip);
        }
    }

    void DeathSound()
    {
    
        sound.PlayOneShot(deathClip);
        
    }

    
}
