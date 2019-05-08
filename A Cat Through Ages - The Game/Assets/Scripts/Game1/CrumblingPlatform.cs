using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrumblingPlatform : MonoBehaviour {

    [SerializeField]
    private SpriteRenderer sprite;
    [SerializeField]
    private float secondsToWait;

    private GameObject CrumbelingPlatform;
    private bool running;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        
        CrumbelingPlatform = gameObject;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(PlatformTimer());
        }
    }

    public IEnumerator PlatformTimer()
    {
        running = true;
        while (running) { 
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<Collider2D>().enabled = false;
            yield return new WaitForSeconds(secondsToWait);
            StartCoroutine(PlatformRespawn());
            //StopCoroutine(Timer());
            //running = false;            
        }
        
    }

    public IEnumerator PlatformRespawn()
    {
            yield return new WaitForSeconds(1);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        Destroy(gameObject);
        MakeCrumblingPlatform(CrumbelingPlatform);
        running = false;

    }

    void MakeCrumblingPlatform(GameObject toBeMade)
    {
        toBeMade.GetComponent<Collider2D>().enabled = true;
        toBeMade.GetComponent<CrumblingPlatform>().enabled = true;
        Instantiate(toBeMade, toBeMade.transform.position, Quaternion.identity);

    }

    
}
