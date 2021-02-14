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
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Rotate(rotationThrust);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Rotate(-rotationThrust);
        }
    }

    private void Rotate(float rotationThisFrame)
    {
        dogeBody.freezeRotation = true; // freezing rotation so we can manually rotate
        transform.Rotate(Vector3.right* rotationThisFrame * Time.deltaTime);
        dogeBody.freezeRotation = false; // unfreeze
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            dogeBody.AddRelativeForce(Vector3.up * thurstSpeed * Time.deltaTime);
        }    
    }

}
