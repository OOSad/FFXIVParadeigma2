using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    int movementSpeed = 10;
    float horizontalInput;
    float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {   
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        UnityEngine.Vector3 cameraForward = GameObject.FindGameObjectWithTag("MainCamera").transform.forward;
        UnityEngine.Vector3 cameraRight = GameObject.FindGameObjectWithTag("MainCamera").transform.right;

        cameraForward.y = 0f;
        cameraRight.y = 0f;

        UnityEngine.Vector3 moveDirection = ((cameraForward * verticalInput + cameraRight * horizontalInput).normalized);
        
        transform.Translate(moveDirection * movementSpeed * Time.deltaTime, Space.World);
    }
}
