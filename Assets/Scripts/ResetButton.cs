using Unity.VisualScripting;
using UnityEngine;

public class ResetButton : MonoBehaviour
{

    public TargetTracker targetTracker;
    private void OnTriggerEnter(Collider collision)
    {

        Debug.Log("Reset Button Hit");

        GameObject target1 = GameObject.Find("t1");
        GameObject target2 = GameObject.Find("t2");
        GameObject target3 = GameObject.Find("t3");
        GameObject target4 = GameObject.Find("t4");
        GameObject target5 = GameObject.Find("t5");
        GameObject target6 = GameObject.Find("t6");


        if (collision.gameObject.tag == "Ball")
        {

            Debug.Log("Ball Hit Reset Button");
            
            
            targetTracker.ResetTargets();

            target1.GetComponent<TargetController>().ResetTarget();
            target2.GetComponent<TargetController>().ResetTarget();
            target3.GetComponent<TargetController>().ResetTarget();
            target4.GetComponent<TargetController>().ResetTarget();
            target5.GetComponent<TargetController>().ResetTarget();
            target6.GetComponent<TargetController>().ResetTarget();

        }
    }

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
