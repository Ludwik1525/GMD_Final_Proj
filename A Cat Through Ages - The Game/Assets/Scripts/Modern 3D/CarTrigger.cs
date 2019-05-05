using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarTrigger : MonoBehaviour
{

    private AudioSource source;
    public AudioClip catScream;

	// Use this for initialization
	void Start ()
    {
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cat"))
        {
            source.PlayOneShot(catScream);
            SceneManager.LoadScene("Lose Scene - Car Accidence");
        }
    }
}
