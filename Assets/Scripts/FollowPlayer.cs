using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public float turnSpeed = 3;
    public float minTurnAngle = -30;
    public float maxTurnAngle = 30;
    public float rotX;
    public float rotY;
    public float cameraDistance = 5f;
    public float cameraLowestPoint = 0f;
    private Vector3 offset;

    void Start() {
        offset = transform.position - player.transform.position;
    }

    void Update() {
        HandleRotate();
        PositionCamera();
        if (transform.position.y <= cameraLowestPoint)
        {
            transform.position = new Vector3(transform.position.x, cameraLowestPoint, transform.position.z);
        }
    }

    void HandleRotate() {
        // get the mouse inputs
        rotY = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;

        // clamp the vertical rotation
        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);

        // rotate the camera
        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + rotY, 0);
    }
    
    void PositionCamera() {
        Vector3 cameraHeight = new Vector3(0, 1, 0);
        Vector3 cameraPosition = player.position - (transform.forward * cameraDistance) + cameraHeight;
        transform.position = cameraPosition;
    }

    public float GetRotY(){
        return rotY;
    }

    public float GetYPosition()
    {
        return transform.position.y;
    }
}