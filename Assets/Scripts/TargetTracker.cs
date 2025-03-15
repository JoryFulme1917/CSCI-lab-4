using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTracker : MonoBehaviour
{
    public bool AllTargetsHit = false;
    public bool AllDragonHit = false;
    public int targetHitCount = 0;
    public int requiredTargets = 6;
    public int dragonHits;
    public int requiredDragonHits = 20;

    public GameObject resetButton;
    public DragonController dragonController;

    void Start()
    {
        // Ensure the reset object has a collider
        if (resetButton != null && resetButton.GetComponent<Collider>() == null)
            Debug.LogError("Reset object needs a collider!");

        dragonHits = 0;

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
            dragonController.DragonDie();
            Debug.Log("All dragon targets hit! Game should end now");
        }

        else if (dragonHits != 0 && dragonHits % 5 == 0)
        {
            dragonController.DragonHitSpecial();

            Debug.Log("fire animation");
        }
        else
        {
            dragonController.DragonHit();
            Debug.Log("dragon should bite");
        }

    }


    public void ResetTargets()
    {
        targetHitCount = 0;
        AllTargetsHit = false;
        Debug.Log("Targets reset. Dialogue returned to initial state.");
    }

    

}