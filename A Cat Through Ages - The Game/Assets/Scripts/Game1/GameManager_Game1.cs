using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager_Game1 : MonoBehaviour {
    public GameObject pauseScreen,introStory;
    private bool paused = false;
    public Button resume;
   
    

    private Scene scene;
	// Use this for initialization
	void Start () {
        
        paused = true;
        Time.timeScale = 0.0f;

        pauseScreen.SetActive(true);
        

        resume.onClick.AddListener(Resume);
        scene = SceneManager.GetActiveScene();
        GetComponentInParent<StandardHealth>().OnDied += RestartGame;


    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Escape ) && !paused)
        {
            pauseScreen.SetActive(true);
            //menu.gameObject.SetActive(true);
            //sliders.SetActive(true);
            Time.timeScale = 0.0f;
        }
        else if(Input.GetKey(KeyCode.Escape) && paused)
        {
            pauseScreen.SetActive(false);
            //menu.gameObject.SetActive(false);
            //sliders.SetActive(false);
            Time.timeScale = 1.0f;
        }
	}

    void Resume()
    {
        pauseScreen.SetActive(false);
        paused = false;
        Time.timeScale = 1.0f;

    }

    public void FinishGame()
    {
        SceneManager.LoadScene("Game2");
    }

    void RestartGame()
    {
        
        SceneManager.LoadScene("Game1");
    }
}
