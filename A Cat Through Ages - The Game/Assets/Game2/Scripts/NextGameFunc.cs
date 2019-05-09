using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextGameFunc : MonoBehaviour {

    public void NextGame()
    {
        SceneManager.LoadScene(2);
    }
}
