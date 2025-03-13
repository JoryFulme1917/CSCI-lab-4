using UnityEngine;

public class TargetController : MonoBehaviour
{



    private void OnTriggerEnter(Collider collision)
    {

        Debug.Log("Target Hit");

        if (collision.gameObject.tag == "Ball")
        {
            
            Debug.Log("Ball Hit Target");

            // inc score counter


            // play some kind of sound

            // maybe trigger dialogue

            
            gameObject.GetComponent<MeshRenderer>().enabled = false;



        }

    }

    public void ResetTarget()
    {
       
        gameObject.GetComponent<MeshRenderer>().enabled = true;
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
