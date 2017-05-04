using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ChanageScene : MonoBehaviour
{

    public void MENU_ACTION_GoToPage(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}