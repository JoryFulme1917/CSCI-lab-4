using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditButton: MonoBehaviour
{ 

    public void TransitionToCredits()
    {
        SceneManager.LoadScene("Credits Scene");
    }
}
