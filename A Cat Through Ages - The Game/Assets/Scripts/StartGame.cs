using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Button startButton;

    private AudioSource source;

    public AudioClip catMeow;
    // Use this for initialization
    void Start ()
    {
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		startButton.onClick.AddListener(GoToFirstGame);
	}

    void GoToFirstGame()
    {
        StartCoroutine(CatMeowSound(catMeow));  
    }

    IEnumerator CatMeowSound(AudioClip clip)
    {
        source.PlayOneShot(catMeow);
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene("Game1");
    }
}
