using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditButton: MonoBehaviour
{
    public Scene onClickOpen;

    public void TransitionToCredits()
    {
        SceneManager.LoadScene("Credits Scene");
    }
}
