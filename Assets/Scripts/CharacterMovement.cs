using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class CharacterMovement : MonoBehaviour 
{
    public float movementSpeed = 1;
    public Vector3 direction;
    float horizontalInput;
    float verticalInput;
    CharacterController controller;
    public float turnSpeed = 3;
    public float minTurnAngle = -30;
    public float maxTurnAngle = 30;
    public float rotX;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        HandleMove();
        HandleRotate();
    } 

    void HandleMove()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        direction = transform.forward * verticalInput + transform.right * horizontalInput;

        controller.Move(direction * movementSpeed * Time.deltaTime);
    }

    void HandleRotate()
    {
        // get the mouse inputs
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;

        // clamp the vertical rotation
        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);

        // rotate the camera
        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);
    }


}