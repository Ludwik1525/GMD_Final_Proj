using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class Human : MonoBehaviour
{
    private float timer;
    public int newTarget;
    public Vector3 target;

    public AudioSource source;
    public AudioClip catMeow;

    private NavMeshAgent navMeshAgent;

    // Use this for initialization
    void Start ()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        if (timer >= newTarget)
        {
            NewTarget();
            timer = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cat"))
        {
            LifeControl.life -= 1;
            source.PlayOneShot(catMeow);

            if (LifeControl.life == 0)
            {
                SceneManager.LoadScene("Lose Scene - Human Hurt");
            }
        }
    }

    void NewTarget()
    {
        float myX = transform.position.x;
        float myZ = transform.position.z;

        float XPos = myX + Random.Range(myX - 100, myX + 100);
        float ZPos = myZ + Random.Range(myZ - 100, myZ + 100);

        target = new Vector3(XPos,transform.position.y,ZPos);

        navMeshAgent.SetDestination(target);
    }
}
