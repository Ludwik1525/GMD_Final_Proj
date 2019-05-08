using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAME3_BearMovement : MonoBehaviour
{

    private Vector3 temp;
    public int randomNumber;
    private Rigidbody rb;

    void Start ()
    {
        temp = transform.position;
        StartCoroutine("Move");
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //rb.AddForce(temp * randomNumber);
        //transform.position = Vector3.MoveTowards(transform.position, temp, 0.1f);

    }

    void SetRandomPos()
        {
        temp = new Vector3(Random.Range(-30+randomNumber, 25-randomNumber), Random.Range(30+randomNumber, -10-randomNumber), 26.6f);
        }

        public IEnumerator Move()
        {
            while (true)
            {
                SetRandomPos();
                yield return new WaitForSeconds(randomNumber);
            }
        }
}
