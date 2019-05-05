using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManage : MonoBehaviour
{

    public Button retry;
    public Button exit;
    public Button menu;


	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        


        retry.onClick.AddListener(Retry);
        exit.onClick.AddListener(Exit);
        menu.onClick.AddListener(BackToMenu);
	}

    void Retry()
    {
        SceneManager.LoadScene("Game4");
    }

    void Exit()
    {
        Application.Quit();
    }

    void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
