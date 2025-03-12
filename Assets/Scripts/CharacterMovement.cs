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


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        HandleMove();
    } 

    void HandleMove()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        direction = transform.forward * verticalInput + transform.right * horizontalInput;

        controller.Move(direction * movementSpeed * Time.deltaTime);
    }
}