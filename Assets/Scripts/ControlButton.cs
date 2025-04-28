using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlButton : MonoBehaviour
{

    public void TransitionToControls()
    {
        SceneManager.LoadScene("Controls Screen");
    }
}

