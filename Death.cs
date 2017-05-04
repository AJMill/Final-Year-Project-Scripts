using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Death : MonoBehaviour
{

    private bool playerInBounds;
    public Text myText;
    public Image warning;
    public Image safety;

    void Start()
    {
        InvokeRepeating("Spotted", 10, 10);
        InvokeRepeating("Warning", 5, 10);
        InvokeRepeating("Disappear", 0, 10);
    }


    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.name == "Player")
        {
            playerInBounds = true;
        }
    }

    void OnTriggerExit(Collider Other)
    {
        if (Other.gameObject.name == "Player")
        {
            playerInBounds = false;
        }
    }

    void Spotted()      
    {
        if (playerInBounds == true)
            SceneManager.LoadScene("Lose");
    }

    void Warning()
    {
        myText.gameObject.SetActive(true);
        warning.gameObject.SetActive(true);
        safety.gameObject.SetActive(false);
    }

    void Disappear()
    {
        myText.gameObject.SetActive(false);
        warning.gameObject.SetActive(false);
        safety.gameObject.SetActive(true);
    }
}
