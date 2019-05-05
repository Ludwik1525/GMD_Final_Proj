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

    public Button startButton;
    public Button endButton;
    public Button resumeButton;
    public Button goToMenuButton;
	
	void Start () {
		startObject.SetActive(true);
        endObject.SetActive(false);
        pauseObject.SetActive(false);
        Time.timeScale = 0;

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
        SceneManager.LoadScene("Cutscene");
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

    void GoToMenu()
    {

    }
}
