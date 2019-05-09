using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public Text ScoreText;
    private int _score = 0;

    void Start()
    {
        EnemyKilled.OnEnemyKilledEvent.AddListener(AddScore);
    }

    private void AddScore()
    {
        _score++;
        ScoreText.text = "Score: " + _score;
    }
}
