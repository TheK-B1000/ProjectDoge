using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Pressed SPACE - Thrusting");
        }    

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Pressed UP");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Pressed DOWN");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Pressed RIGHT");
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Pressed LEFT");
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Pressed D - Rotate Right");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Pressed A - Rotate Left");
        }
       
    }

}
