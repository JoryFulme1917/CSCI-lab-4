using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{

    public void TransitionToTitle()
    {
        SceneManager.LoadScene("Title Screen");
    }
}
