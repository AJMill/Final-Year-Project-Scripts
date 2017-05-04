using UnityEngine;
using System.Collections;

public class canvasControl_level : MonoBehaviour {

    [SerializeField]
    private CanvasGroup Canvas01;
    [SerializeField]
    private CanvasGroup Canvas02;
   

    void Awake()
    {
        Canvas02.alpha = 0f;
        Canvas02.interactable = false;
        Canvas02.blocksRaycasts = false;
        
    }

    public void OnButtonClick()
    {
        Canvas02.alpha = 1f;
        Canvas02.interactable = true;
        Canvas02.blocksRaycasts = true;
        Canvas01.alpha = 0f;
        Canvas01.interactable = false;
        Canvas01.blocksRaycasts = false;
       
    }
}

