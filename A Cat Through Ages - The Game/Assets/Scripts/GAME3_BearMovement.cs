using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAME3_BearMovement : MonoBehaviour
{

    private Vector3 temp;

    void Start ()
    {
        temp = transform.position;
        StartCoroutine("Move");
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, temp, 0.1f);

    }

    void SetRandomPos()
        {
        temp = new Vector3(Random.Range(-300f, 250f), Random.Range(300f, -100f), 26.6f);
        }

        public IEnumerator Move()
        {
            while (true)
            {
                SetRandomPos();
                yield return new WaitForSeconds(1);
            }
        }
}
