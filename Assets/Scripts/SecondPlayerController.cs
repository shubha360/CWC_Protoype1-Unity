using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 50.0f;

    private float verticalInput;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical2");
        horizontalInput = Input.GetAxis("Horizontal2");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        if (verticalInput > 0)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        } 
        else if (verticalInput < 0)
        {
            transform.Rotate(Vector3.down * Time.deltaTime * turnSpeed * horizontalInput);
        }
    }
}
