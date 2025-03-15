using UnityEngine;

public class DragonTarget : MonoBehaviour
{

    public TargetTracker targetTracker;
    

   

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Ball Hit Dragon");

            // Increment count only once
            targetTracker.DragonTargetHit();

           
        }
    }







    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (targetTracker == null)
        {
            targetTracker = GetComponent<TargetTracker>();
            Debug.LogWarning("Dragon Target Tracker not assigned to " + gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
