using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GAME3_GameManager : MonoBehaviour
{

    public GameObject startObject;
    public GameObject endObject;
    public GameObject pauseObject;
    public GameObject coolstory;

    public Button nextButton;
    public Button startButton;
    public Button endButton;
    public Button resumeButton;
    public Button goToMenuButton;
	
	void Start () {
        coolstory.SetActive(true);
		startObject.SetActive(false);
        endObject.SetActive(false);
        pauseObject.SetActive(false);
        Time.timeScale = 0;

        nextButton.onClick.AddListener(Next);
        startButton.onClick.AddListener(StartGame);
        endButton.onClick.AddListener(EndGame);
        resumeButton.onClick.AddListener(Resume);
        goToMenuButton.onClick.AddListener(GoToMenu);
    }
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseObject.SetActive(true);
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().volume = 0.1f;
            Time.timeScale = 0;
        }
	}

    void StartGame()
    {
        Time.timeScale = 1;
        startObject.SetActive(false);
    }

    void EndGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game4");
    }

    public void SetEndObject()
    {
        Time.timeScale = 0;
        endObject.SetActive(true);
    }

    void Resume()
    {
        Time.timeScale = 1;
        pauseObject.SetActive(false);
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().volume = 1f;
    }

    void Next()
    {
        Time.timeScale = 1;
        coolstory.SetActive(false);
        startObject.SetActive(true);
    }

    void GoToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
