using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseGame3 : MonoBehaviour {
    public GameObject pauseMenu;
    private bool isPaused = false;
    public Button resume;
    public Button menu;
    public Slider sliderMusic;
    public AudioSource audioSource;

    // Use this for initialization
    void Start () {
        pauseMenu.gameObject.SetActive(false);
        sliderMusic.value = 0.5f;
        resume.onClick.AddListener(Resume);
        menu.onClick.AddListener(BackToMenu);
    }
	
	// Update is called once per frame
	public void Update () {
 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                pauseMenu.SetActive(true);
                isPaused = true;
                Time.timeScale = 0.0f;
            } else
            {
                pauseMenu.SetActive(false);
                isPaused = false;
                Time.timeScale = 1.0f;
            }
        }
        audioSource.volume = sliderMusic.value;
    }

    void Resume()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
        Time.timeScale = 1.0f;
    }

    void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
