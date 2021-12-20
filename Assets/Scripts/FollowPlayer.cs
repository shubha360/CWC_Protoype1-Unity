using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Camera settings. Single camera is used for two camera positions.

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    
    // Position and rotation of the normal camera
    private Vector3 positionNormal = new Vector3(0, 5, -7);
    private Quaternion rotationNormal = Quaternion.Euler(20, 0, 0);

    // Position and rotation of the secondary-top camera
    private Vector3 positionTop = new Vector3(0, 18, 4);
    private Quaternion rotationTop = Quaternion.Euler(90, 0, 0);

    // Determines if topcam is active. Should be inactive at start.
    private bool topCam = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {   
        // Right shift switches the camera
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            if (!topCam)
            {
                topCam = true;
            } else
            {
                topCam = false;
            }
        }

        if (topCam)
        {
            transform.position = player.transform.position + positionTop;
            transform.rotation = rotationTop;
        } else // normal camera
        {
            transform.position = player.transform.position + positionNormal;
            transform.rotation = rotationNormal;
        }
    }
}
