using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTrigger : MonoBehaviour
{
    public GameObject food;

	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cat"))
        {
            if (food.CompareTag("bird") && LifeControl.currentBird < 5)
            {
                LifeControl.currentBird += 1;
            }
            else if (food.CompareTag("frog") && LifeControl.currentFrog < 5)
            {
                LifeControl.currentFrog += 1;
            }

            Destroy(food);
        }
    }
}
