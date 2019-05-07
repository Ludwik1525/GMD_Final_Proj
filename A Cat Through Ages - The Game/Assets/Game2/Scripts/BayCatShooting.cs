using UnityEngine;


public class BayCatShooting : MonoBehaviour
{
    public GameObject Bullet;
    public Transform ShootFrom;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject temp = Instantiate(Bullet, ShootFrom.position, Quaternion.Euler(90, 0, 0));
            temp.GetComponent<Rigidbody>().AddForce(transform.up * 400);
        }
    }

}

