using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class ThrowObject : MonoBehaviour
{
    public Transform cameraPosition;
    public Transform throwPoint;
    public GameObject originalProjectile;
    public KeyCode throwKey = KeyCode.Mouse0;
    public float cooldown;
    public float throwPower;
    public float throwArc;
    bool throwReady;
    private Animator animator;
    public float throwDelay;

    void Start()
    {
        throwReady = true;
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        if(Input.GetKeyDown(throwKey) && throwReady){
            StartThrowAnimation();
        }
        
    }
    
    void StartThrowAnimation()
    {
        throwReady = false;
        animator.SetBool("Throwing", true);
        
        Invoke("Throw", throwDelay); 
    }
    
    

    void Throw()
    {
        GameObject projectile = Instantiate(originalProjectile, throwPoint.position, cameraPosition.rotation);
        Rigidbody projectileBody = projectile.GetComponent<Rigidbody>();
        Vector3 totalForce = cameraPosition.forward * throwPower + transform.up * throwArc;
        projectileBody.AddForce(totalForce);
        
        Invoke("ResetThrow", cooldown);
    }

    void ResetThrow()
    {
        throwReady = true;
        animator.SetBool("Throwing", false);
    }
}