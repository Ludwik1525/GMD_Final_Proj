using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject ToSpawn;
    public Transform Player;

    public Transform[] Locations1, Locations2;

    private bool _spawn1;
    private int _dif = 1;

    private IEnumerator _spawnRoutine;
	// Use this for initialization
	void Start ()
    {
        _spawn1 = true;
        _spawnRoutine = SpawnRoutine();
        StartCoroutine(_spawnRoutine);
        ScoreScript.DifficultyEvent.AddListener(DifIncrease);
    }

    private void Spawn()
    {
        if (_spawn1)
        {
            GameObject go = Instantiate(ToSpawn, Locations1[Random.Range(0, Locations1.Length)].position, Quaternion.Euler(90,0,0));
            go.GetComponent<Navigator2D>().Target = Player;
            _spawn1 = false;
        }
        else
        {
            GameObject go = Instantiate(ToSpawn, Locations2[Random.Range(0, Locations2.Length)].position, Quaternion.Euler(90, 0, 0));
            go.GetComponent<Navigator2D>().Target = Player;
            _spawn1 = true;
        }
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            for (int i = 0; i < _dif; i++)
            {
                Spawn();
            }
        }
    }

    void DifIncrease()
    {
        _dif++;
    }

    void OnDestroy()
    {
        ScoreScript.DifficultyEvent.RemoveListener(DifIncrease);
    }
}
