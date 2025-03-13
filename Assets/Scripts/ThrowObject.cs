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

    void Start()
    {
        throwReady = true;   
    }

    void Update()
    {
        if(Input.GetKeyDown(throwKey) && throwReady){
            Throw();
        }   
    }

    void Throw()
    {
        throwReady = false;
        GameObject projectile = Instantiate(originalProjectile, throwPoint.position, cameraPosition.rotation);
        Rigidbody projectileBody = projectile.GetComponent<Rigidbody>();
        Vector3 totalForce = cameraPosition.transform.position * throwPower + transform.up * throwArc;
        projectileBody.AddForce(totalForce);
        //https://discussions.unity.com/t/how-to-make-a-delay-before-an-action/177659
        Invoke("ResetThrow", cooldown);
    }

    void ResetThrow()
    {
        throwReady = true;
    }
}
