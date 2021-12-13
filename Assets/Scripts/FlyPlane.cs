using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPlane : MonoBehaviour
{
    private float planeSpeed = 20.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * planeSpeed);
    }
}
