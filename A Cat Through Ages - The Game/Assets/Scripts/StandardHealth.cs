using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardHealth : MonoBehaviour, IHealth {

    //Not setting starting health at start since type of health could be different from game to game, could even be a list but IDK
    [SerializeField] private int startingHealth;
    private int currentHealth;

    //event specified from IHealth interface
    public event Action OnDied = delegate { };

        
    public void AdjustHealth(int healthAdjustment)
    {
        
        currentHealth -= healthAdjustment;

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        OnDied();
        GameObject.Destroy(this.gameObject);
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.collider.gameObject.tag == "FrontalAttack")
        {
            AdjustHealth(1);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "FallingDeath")
        {
            AdjustHealth(1);
        }
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Finish")
        {
            gameObject.GetComponent<PlayerMovementGame1>().enabled = false;
            gameObject.GetComponentInChildren<GameManager_Game1>().FinishGame();
            //anim.Play("GoUp");



        }
    }
}
