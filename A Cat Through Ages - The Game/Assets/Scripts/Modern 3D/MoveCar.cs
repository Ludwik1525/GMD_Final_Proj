using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//using Vuforia;
using Object = System.Object;

public class MoveCar : MonoBehaviour, IMove
{
    private float timer;
    public Vector3 target;
    public float returnAfter;

    private bool haveMove = false;

    private NavMeshAgent navMeshAgent;

    public event Action<Input> OnPlayerInput;

    // Use this for initialization
    void Start ()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

    }
	
	// Update is called once per frame
	void Update ()
    {
      
            Move();
    }

    IEnumerator MoveTo(float second)
    {
        float myZ;
        float ZPos;

        if (!haveMove)
        {
            myZ = transform.position.z;
            ZPos = myZ + 10;

            target = new Vector3(transform.position.x, transform.position.y, ZPos);

            navMeshAgent.SetDestination(target);
            

            yield return new WaitForSeconds(second);

            haveMove = true;
        }
        else
        {

            myZ = transform.position.z;
            ZPos = myZ - 10;

            target = new Vector3(transform.position.x, transform.position.y, ZPos);

            navMeshAgent.SetDestination(target);

            yield return new WaitForSeconds(second);

            haveMove = false;
        }
    }

    public void Move()
    {
        StartCoroutine(MoveTo(returnAfter));
    }

    public void Jump()
    {
        throw new NotImplementedException();
    }
}
