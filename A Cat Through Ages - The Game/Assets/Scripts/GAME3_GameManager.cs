using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GAME3_GameManager : MonoBehaviour
{

    public GameObject startObject;
    public GameObject endObject;

    public Button startButton;
    public Button endButton;
	
	void Start () {
		startObject.SetActive(true);
        endObject.SetActive(false);
        Time.timeScale = 0;

        startButton.onClick.AddListener(StartGame);
        endButton.onClick.AddListener(EndGame);
    }
	
	void Update () {
		
	}

    void StartGame()
    {
        Time.timeScale = 1;
        startObject.SetActive(false);
    }

    void EndGame()
    {

    }

    public void SetEndObject()
    {
        Time.timeScale = 0;
        endObject.SetActive(true);
    }
}
