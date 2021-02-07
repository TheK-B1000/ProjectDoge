using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody dogeBody;

    // Start is called before the first frame update
    void Start()
    {
      dogeBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Pressed D - Rotate Right");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Pressed A - Rotate Left");
        }
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            dogeBody.AddRelativeForce(Vector3.up);
            Debug.Log("Pressed SPACE");
        }    
    }

}
