using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GAME3_CollectKittens : MonoBehaviour {

    public AudioClip collect;
    public AudioSource source;
    public Text current;
    private int counter = 0;
    public int max;

    public GameObject particles;

    void Start()
    {
    }

    void Update()
    {
        if (counter == max)
        {
            SceneManager.LoadScene("Cutscene");
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
    }

}
