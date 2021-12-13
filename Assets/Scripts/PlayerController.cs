using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // Getting user input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Move the vehicle sideward only if speed is not 0

        if (verticalInput > 0)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        } else if (verticalInput < 0)
        {
            transform.Rotate(Vector3.down * Time.deltaTime * turnSpeed * horizontalInput);
        }
    }
}
