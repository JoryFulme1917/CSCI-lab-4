using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTracker : MonoBehaviour
{
    public bool AllTargetsHit = false;
    public bool AllDragonHit = false;
    public int targetHitCount = 0;
    public int requiredTargets = 6;
    public int dragonHits = 0;
    public int requiredDragonHits = 20;

    public GameObject resetButton;
    
    void Start()
    {
        // Ensure the reset object has a collider
        if (resetButton != null && resetButton.GetComponent<Collider>() == null)
            Debug.LogError("Reset object needs a collider!");
    }
    
    public void TargetHit()
    {
        targetHitCount++;
        
        if (targetHitCount >= 6)
        {
            AllTargetsHit = true;
            Debug.Log("All targets hit! Dialogue will change.");
        }
    }
    
    public void DragonTargetHit()
    {
        dragonHits++;

        if (dragonHits >= 20)
        {
            AllDragonHit = true;
            Debug.Log("All dragon targets hit! Game should end now");
        }

    }


    public void ResetTargets()
    {
        targetHitCount = 0;
        AllTargetsHit = false;
        Debug.Log("Targets reset. Dialogue returned to initial state.");
    }
}