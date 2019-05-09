using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigator2D : MonoBehaviour
{

    public Transform Target;
    public float Speed;

    private Rigidbody _body;
    private Vector3 _mVelocity = Vector3.zero;

	// Use this for initialization
	void Start ()
    {
        _body = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		_body.velocity = Vector3.SmoothDamp(_body.velocity, (Target.position-transform.position).normalized, ref _mVelocity, 0.05f);
    }
}
