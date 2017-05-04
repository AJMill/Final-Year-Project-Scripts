using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public GameObject Main;
    public GameObject Options;
    public GameObject Controls;
    public GameObject Credits;
    public GameObject Exit;

    // Use this for initialization
    void Start ()
    {
        Main.SetActive(true);
        Options.SetActive(false);
        Controls.SetActive(false);
        Credits.SetActive(false);
        Exit.SetActive(false);
    }
	
	public void MainLoad()
    {
        Main.SetActive(true);
        Options.SetActive(false);
        Controls.SetActive(false);
        Credits.SetActive(false);
        Exit.SetActive(false);
    }
    public void OptionsLoad()
    {
        Main.SetActive(false);
        Options.SetActive(true);
        Controls.SetActive(false);
        Credits.SetActive(false);
        Exit.SetActive(false);
    }
    public void ControlsLoad()
    {
        Main.SetActive(false);
        Options.SetActive(false);
        Controls.SetActive(true);
        Credits.SetActive(false);
        Exit.SetActive(false);
    }
    public void CreditsLoad()
    {
        Main.SetActive(false);
        Options.SetActive(false);
        Controls.SetActive(false);
        Credits.SetActive(true);
        Exit.SetActive(false);
    }
    public void ExitLoad()
    {
        Main.SetActive(false);
        Options.SetActive(false);
        Controls.SetActive(false);
        Credits.SetActive(false);
        Exit.SetActive(true);
    }
}
