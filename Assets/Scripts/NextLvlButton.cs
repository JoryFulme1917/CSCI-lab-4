using UnityEngine;
using Unity.VisualScripting;
using TMPro;

public class NextLvlButton : MonoBehaviour
{

    public TargetTracker targetTracker;
 
    public Canvas canvas;

    private void OnTriggerEnter(Collider collision)
    {

        Debug.Log("Next lvl Button Hit");


        if (collision.gameObject.tag == "Ball")
        {

            Debug.Log("Ball Hit next lvl Button");

           targetTracker.changeScene();


        }
    }
















    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;

        

    }

    // Update is called once per frame
    void Update()
    {
        if (targetTracker.AllTargetsHit)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            
        }
    }
}
