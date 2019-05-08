using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth {

    event System.Action OnDied;
    event System.Action<float> OnHealthChanged;
    //adjust health functions as both adding and removing health - can be 1-100 or fx 1-3
    void AdjustHealth(int healthAdjustment);
}
