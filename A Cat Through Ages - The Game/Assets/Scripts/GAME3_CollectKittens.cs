using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GAME3_CollectKittens : MonoBehaviour {

    public AudioClip collect;
    public AudioClip bearAttack;
    public AudioSource source;
    public Text current;
    private int counter = 0;
    public int max;

    public GameObject particles;
    private GAME3_GameManager manager;

    void Start()
    {
        manager = GetComponent<GAME3_GameManager>();
    }

    void Update()
    {
        if (counter == max)
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().volume = 0.1f;
            source.volume = 0.1f;
            manager.SetEndObject();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Kitten")
        {
            col.gameObject.SetActive(false);
            source.PlayOneShot(collect);
            counter++;
            current.text = "" + counter + " / 15";
            Instantiate(particles, col.transform.position, Quaternion.identity);
        }

        if (col.gameObject.tag == "Bear")
        {
            this.transform.position = new Vector3(-313, -295, 30);
            source.PlayOneShot(bearAttack);
        }
    }

}
