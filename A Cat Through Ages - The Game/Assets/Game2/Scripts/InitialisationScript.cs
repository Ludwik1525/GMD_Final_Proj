using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InitialisationScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        if (EnemyKilled.OnEnemyKilledEvent == null)
        {
            EnemyKilled.OnEnemyKilledEvent = new UnityEvent();
        }

        if (Kill.LoseEvent == null)
        {
            Kill.LoseEvent = new UnityEvent();
        }

        Time.timeScale = 0;
    }
}
