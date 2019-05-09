using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedCollider : MonoBehaviour
{

    private BoxCollider _collider;

    void Start()
    {
        _collider = GetComponent<BoxCollider>();
        StartCoroutine(DelayedActivation());
    }

    IEnumerator DelayedActivation()
    {
        yield return new WaitForSeconds(1.5f);
        _collider.enabled = true;
    }
}
