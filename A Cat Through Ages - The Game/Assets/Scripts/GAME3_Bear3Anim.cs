using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAME3_Bear3Anim : MonoBehaviour {

    [HideInInspector]
    public Animator anim;

    private float prevPosY;
    private float prevPosX;


    void Start()
    {
        anim = GetComponent<Animator>();

        prevPosY = transform.position.y;
        prevPosX = transform.position.x;
    }

    void Update()
    {
        if (prevPosY < transform.position.y)
        {
            anim.Play("GAME3-Bear3Up");
        }
        if (prevPosY > transform.position.y)
        {
            anim.Play("GAME3-Bear3Down");
        }

        if (prevPosY == transform.position.y)
        {
            if (prevPosX < transform.position.x)
            {
                anim.Play("GAME3-Bear3Right");
            }
            if (prevPosX > transform.position.x)
            {
                anim.Play("GAME3-Bear3Left");
            }
        }

        prevPosY = transform.position.y;
        prevPosX = transform.position.x;
    }
}
