using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAME3_BearAnim : MonoBehaviour {

    [HideInInspector]
    public Animator anim;

    private float prevPosY;
    private float prevPosX;
   

    void Start ()
    {
        anim = GetComponent<Animator>();

        prevPosY = transform.position.y;
        prevPosX = transform.position.x;
    }
	
	void Update () {
        if (prevPosY < transform.position.y)
        {
            anim.Play("GAME3-Bear1Up");
        }
        if (prevPosY > transform.position.y)
        {
            anim.Play("GAME3-Bear1Down");
        }

        if (prevPosY == transform.position.y)
        {
            if (prevPosX < transform.position.x)
            {
                anim.Play("GAME3-Bear1Right");
            }
            if (prevPosX > transform.position.x)
            {
                anim.Play("GAME3-Bear1Left");
            }
        }

        prevPosY = transform.position.y;
        prevPosX = transform.position.x;
    }
}
