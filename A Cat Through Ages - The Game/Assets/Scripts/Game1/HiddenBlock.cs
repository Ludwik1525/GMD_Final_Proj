using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenBlock : MonoBehaviour {

    public Collider2D col;

	// Use this for initialization
	void Start () {
        col = gameObject.GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.GetComponent<Collider2D>().gameObject.tag == "Player")
        {
            col.isTrigger = false;
        }
    }
}
