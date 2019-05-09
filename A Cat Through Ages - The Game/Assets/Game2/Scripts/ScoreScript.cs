using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static UnityEvent DifficultyEvent;
    public Text ScoreText;
    private int _score = 0;

    void Start()
    {
        if(DifficultyEvent == null)
        {
            DifficultyEvent = new UnityEvent();
        }
        if (EnemyKilled.OnEnemyKilledEvent == null)
        {
            EnemyKilled.OnEnemyKilledEvent = new UnityEvent();
        }
        EnemyKilled.OnEnemyKilledEvent.AddListener(AddScore);
    }

    private void AddScore()
    {
        _score++;
        ScoreText.text = "Score: " + _score;
        if (_score % 5 == 0)
        {
            DifficultyEvent.Invoke();
        }
    }

    void OnDestroy()
    {
        EnemyKilled.OnEnemyKilledEvent.RemoveListener(AddScore);
    }
}
