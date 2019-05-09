using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Kill : MonoBehaviour
{

    public static UnityEvent LoseEvent;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cat")
        {
            LoseEvent.Invoke();
        }
    }
    
}
