using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{

    public void QuitRequest()
    {
        Debug.Log("I want to quit");
        Application.Quit();
    }
}
