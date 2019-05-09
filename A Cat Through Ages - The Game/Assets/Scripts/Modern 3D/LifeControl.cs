using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeControl : MonoBehaviour {

    public static int life = 3;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public Text date;
    public static int currentBird = 0;
    public static int currentFrog = 0;
    public Text collectedBird;
    public Text collectedFrog;

    // Use this for initialization
    void Start ()
    {
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update ()
    {
        collectedBird.text = currentBird.ToString();
        collectedFrog.text = currentFrog.ToString();

        if (life == 2)
        {
            heart1.SetActive(false);
        }
        else if (life == 1)
        {
            heart2.SetActive(false);
        }
        else if (life == 0)
        {
            heart3.SetActive(false);
        }

        if (date.text.Equals("32")&&currentBird+currentFrog<10)
        {
            SceneManager.LoadScene("Lose Scene - Starvation");
        }else if (!date.text.Equals("32") && currentBird + currentFrog >= 10)
        {
            SceneManager.LoadScene("Win Scene - Game4");
        }
    }
}
