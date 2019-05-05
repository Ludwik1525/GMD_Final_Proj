using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{

    public Text date;
    private float count = 0;
    private bool start = false;
    public Button btn;
    private float startTime = 0;
    public GameObject cat;

	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(count);

        btn.onClick.AddListener(ButtonClick);

        if (!start)
        {
            count = Mathf.Floor((Time.time-startTime) / 60f);
            date.text = ""+(count+15);
        }
    }

    void ButtonClick()
    {
        start = true;
        startTime = Time.time;
    }
}
