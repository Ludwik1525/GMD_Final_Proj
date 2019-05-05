using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAME3_CameraFollow : MonoBehaviour {

    public GameObject player;
    private bool flatMode = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!flatMode)
            {
                player.transform.Rotate(-45, 0,0);
                this.gameObject.transform.Rotate(-35,0,0);
                flatMode = true;
            }
            else
            {
                player.transform.Rotate(45, 0, 0);
                this.gameObject.transform.Rotate(35, 0, 0);
                flatMode = false;
            }
        }
    }

    void LateUpdate()
    {
        if(!flatMode) transform.position = player.transform.position + new Vector3(0, -20, -20);
        else transform.position = player.transform.position + new Vector3(0, -20, -10);
    }
}
