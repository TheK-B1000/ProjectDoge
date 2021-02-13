using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody dogeBody;
    [SerializeField] float thurstSpeed = 100.0f;
    [SerializeField] float rotationThrust = 100.0f;

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
            Rotate(rotationThrust);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Rotate(-rotationThrust);
        }
    }

    private void Rotate(float rotationThisFrame)
    {
        transform.Rotate(Vector3.forward * rotationThrust * Time.deltaTime);
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            dogeBody.AddRelativeForce(Vector3.up * thurstSpeed * Time.deltaTime);
        }    
    }

}
