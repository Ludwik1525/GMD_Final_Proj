using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAME3_Bear2Anim : MonoBehaviour {

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
            anim.Play("GAME3-Bear2Up");
        }
        if (prevPosY > transform.position.y)
        {
            anim.Play("GAME3-Bear2Down");
        }

        if (prevPosY == transform.position.y)
        {
            if (prevPosX < transform.position.x)
            {
                anim.Play("GAME3-Bear2Right");
            }
            if (prevPosX > transform.position.x)
            {
                anim.Play("GAME3-Bear2Left");
            }
        }

        prevPosY = transform.position.y;
        prevPosX = transform.position.x;
    }
}
