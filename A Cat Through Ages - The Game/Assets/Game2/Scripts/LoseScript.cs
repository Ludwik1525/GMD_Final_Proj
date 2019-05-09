using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{

    public GameObject LoseUi;
    private BayCatShooting _shooting;

    void Start()
    {
        _shooting = GetComponent<BayCatShooting>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Lose();
        }
        
    }

    private void Lose()
    {
        Debug.Log("lose func");
        Time.timeScale = 0;
        LoseUi.SetActive(true);
        _shooting.enabled = false;
        SceneManager.LoadScene("Game3");
    }
    

}
