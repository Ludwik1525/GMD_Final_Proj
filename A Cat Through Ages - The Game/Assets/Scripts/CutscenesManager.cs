using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CutscenesManager : MonoBehaviour
{

    public GameObject cutscene1;
    public GameObject cutscene2;
    public GameObject cutscene3;
    public GameObject cutscene4;
    public GameObject cutscene5;

    public Button continue1;
    public Button continue2;
    public Button continue3;
    public Button continue4;
    public Button continue5;

    void Start ()
    {
        cutscene1.SetActive(true);
        cutscene2.SetActive(false);
        cutscene3.SetActive(false);
        cutscene4.SetActive(false);
        cutscene5.SetActive(false);

        continue1.onClick.AddListener(GoToFirstGame);
        continue2.onClick.AddListener(GoToSecondGame);
        continue3.onClick.AddListener(GoToThirdGame);
        continue4.onClick.AddListener(GoToFourthGame);
        continue5.onClick.AddListener(GoBackToMenu);
    }
	
	void Update () {
		
	}

    void GoToFirstGame()
    {
        cutscene1.SetActive(false);
        cutscene2.SetActive(true);
        SceneManager.LoadScene("Game1");
    }

    void GoToSecondGame()
    {
        cutscene2.SetActive(false);
        cutscene3.SetActive(true);
        SceneManager.LoadScene("Game2");
    }

    void GoToThirdGame()
    {
        cutscene3.SetActive(false);
        cutscene4.SetActive(true);
        SceneManager.LoadScene("Game3");
    }

    void GoToFourthGame()
    {
        cutscene4.SetActive(false);
        cutscene5.SetActive(true);
        SceneManager.LoadScene("Game4");
    }

    void GoBackToMenu()
    {
        cutscene5.SetActive(false);
        cutscene1.SetActive(true);
        SceneManager.LoadScene("Menu");
    }
}
