using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public StandardHealth health;
    public Animator anim;
    private AnimationClip clip;

    private void Start()
    {
        //hearts = GetComponentInChildren<HeartManager>();
        //print(hearts);

        health = GetComponent<StandardHealth>();
        


    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.collider.gameObject.tag == "FrontalAttack")
        {
            health.AdjustHealth(1);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "FallingDeath")
        {
            health.AdjustHealth(1);
        }
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Finish")
        {
           
            gameObject.GetComponent<PlayerMovementGame1>().enabled = false;
            //anim.Play("GoUp");
            

            StartCoroutine(GameEnding(1));
        }
    }
    IEnumerator GameEnding(float time)
    {

        yield return new WaitForSeconds(time);
        GetComponentInChildren<GameManager_Game1>().FinishGame();
    }


}
