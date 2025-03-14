using UnityEngine;

public class TargetController : MonoBehaviour
{
    public TargetTracker targetTracker;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {   
            Debug.Log("Ball Hit Target");
            
            // Increment count only once
            targetTracker.TargetHit();
            
            // Disable the mesh renderer
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    public void ResetTarget()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }

    void Start()
    {
        // Don't try to get component from self
        if (targetTracker == null)
        {
            targetTracker = GetComponent<TargetTracker>();
            Debug.LogWarning("Target Tracker not assigned to " + gameObject.name);
        }
    }
}