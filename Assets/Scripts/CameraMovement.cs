using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    GameObject PlayerCharacter;
    public int rotationSpeed = 200;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCharacter = GameObject.FindGameObjectsWithTag("PlayerCharacter")[0];
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetMouseButton(0))
        {
            MoveCameraOnAnyGivenDirection();
        }

        transform.LookAt(PlayerCharacter.transform);

        if (Input.mouseScrollDelta.y > 0 || Input.mouseScrollDelta.y < 0)
        {
            ScrollCameraForwardsOrBackwards();
        }
    }

    void MoveCameraOnAnyGivenDirection()
    {
        if (Input.GetAxis("Mouse X") < 0)
        {
            transform.Translate(UnityEngine.Vector3.left * (Input.GetAxis("Mouse X") * rotationSpeed) * Time.deltaTime);
        }

        else if (Input.GetAxis("Mouse X") > 0)
        {
            transform.Translate(UnityEngine.Vector3.right * (Input.GetAxis("Mouse X") * rotationSpeed * -1) * Time.deltaTime);
        }

        if (Input.GetAxis("Mouse Y") < 0)
        {
            transform.Translate(UnityEngine.Vector3.down * (Input.GetAxis("Mouse Y") * rotationSpeed) * Time.deltaTime);
        }

        else if (Input.GetAxis("Mouse Y") > 0)
        {
            transform.Translate(UnityEngine.Vector3.up * (Input.GetAxis("Mouse Y") * (rotationSpeed * -1)) * Time.deltaTime);
        }

    }

    void ScrollCameraForwardsOrBackwards()
    {
        if (Input.mouseScrollDelta.y > 0)
        {
            transform.Translate(UnityEngine.Vector3.forward);   
        }
        else if (Input.mouseScrollDelta.y < 0)
        {
            transform.Translate(UnityEngine.Vector3.back);   
        }
    }
}
