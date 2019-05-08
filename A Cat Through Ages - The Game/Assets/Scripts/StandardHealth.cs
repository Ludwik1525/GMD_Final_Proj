using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StandardHealth : MonoBehaviour, IHealth {

    //Not setting starting health at start since type of health could be different from game to game, could even be a list but IDK
    [SerializeField] private int startingHealth;
    private int currentHealth;
    private Vector2 startPosition;
    

    //event specified from IHealth interface
    public event Action OnDied = delegate { };
    public event Action <float>OnHealthChanged = delegate { };


    private void Start()
    {

        
        startingHealth = 1;
        currentHealth = startingHealth;
    }
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
        
    }

    

   
}
