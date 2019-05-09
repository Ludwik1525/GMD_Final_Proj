using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerCam : MonoBehaviour {

    public GameObject player;
    public Transform target, leftBound, rightBounds;

    private float camWidth, camHeight, levelMaxX;


    private Vector3 offset;        

    
    void Start()
    {

        camWidth = Camera.main.orthographicSize * 2;
        camWidth = camHeight * Camera.main.aspect;

        
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        if(player.transform.position.y < -0.3f)
        {
            transform.position = new Vector3(player.transform.position.x + offset.x, -1.16f, -10);

        }
        if(player.transform.position.y > 0)
        {
            transform.position = new Vector3(player.transform.position.x + offset.x, 1.24f, -10);
        }
    }
}
