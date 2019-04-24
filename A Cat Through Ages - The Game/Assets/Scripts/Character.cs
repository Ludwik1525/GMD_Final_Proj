using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour,IHealth,IMove {
    public event Action OnDied;

    public void AdjustHealth(int healthAdjustment)
    {
        throw new NotImplementedException();
    }

    public void Move()
    {
        throw new NotImplementedException();
    }

   
}
