using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public float turnSpeed = 3;
    public float minTurnAngle = -30;
    public float maxTurnAngle = 30;
    public float rotX;

    // Update is called once per frame
    void Update () {
        transform.position = player.transform.position;
        HandleRotate();
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
