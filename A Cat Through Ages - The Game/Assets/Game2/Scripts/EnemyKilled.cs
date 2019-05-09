using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyKilled : MonoBehaviour {

    public static UnityEvent OnEnemyKilledEvent;

    void OnDestroy()
    {
        OnEnemyKilledEvent.Invoke();
    }
}
