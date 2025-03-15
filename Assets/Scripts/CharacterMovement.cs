using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private Animator animator;


    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        HandleMove();
        HandleRotate();
        UpdateAnimations();
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
    
    void UpdateAnimations()
    {
        animator.SetFloat("Horizontal", horizontalInput);
        animator.SetFloat("Vertical", verticalInput);
        
        bool isWalking = Mathf.Abs(horizontalInput) > 0.1f || Mathf.Abs(verticalInput) > 0.1f;
        animator.SetBool("Walking", isWalking);
    }
}