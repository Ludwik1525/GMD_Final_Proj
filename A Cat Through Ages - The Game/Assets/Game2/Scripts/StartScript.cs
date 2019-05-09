using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{

    public GameObject StartUi, CoolStoryUi;
    public BayCatShooting Shooting;
    
    public void OnNextClick()
    {
        CoolStoryUi.SetActive(false);
        StartUi.SetActive(true);
    }

    public void OnStartClick()
    {
        StartUi.SetActive(false);
        Time.timeScale = 1;
        Shooting.enabled = true;
    }

}
