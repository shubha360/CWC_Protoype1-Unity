using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    
    private Vector3 positionNormal = new Vector3(0, 5, -7);
    private Quaternion rotationNormal = Quaternion.Euler(20, 0, 0);
    
    private Vector3 positionTop = new Vector3(0, 18, 4);
    private Quaternion rotationTop = Quaternion.Euler(90, 0, 0);

    private bool topCam = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {   
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
        } else
        {
            transform.position = player.transform.position + positionNormal;
            transform.rotation = rotationNormal;
        }
    }
}
