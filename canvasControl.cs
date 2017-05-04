using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasControl : MonoBehaviour
{

    [SerializeField]
    private CanvasGroup Canvas01;
    [SerializeField]
    private CanvasGroup Canvas02;
    [SerializeField]
    private CanvasGroup Canvas03;
    [SerializeField]
    private CanvasGroup Canvas04;
    [SerializeField]


    void Start()
    {
        Canvas02.alpha = 0f;
        Canvas02.interactable = false;
        Canvas02.blocksRaycasts = false;
        Canvas03.alpha = 0f;
        Canvas03.interactable = false;
        Canvas03.blocksRaycasts = false;
        Canvas04.alpha = 0f;
        Canvas04.interactable = false;
        Canvas04.blocksRaycasts = false;
    }

    public void OnButtonClick()
    {
        Canvas02.alpha = 1f;
        Canvas02.interactable = true;
        Canvas02.blocksRaycasts = true;
        Canvas01.alpha = 0f;
        Canvas01.interactable = false;
        Canvas01.blocksRaycasts = false;
        Canvas03.alpha = 0f;
        Canvas03.interactable = false;
        Canvas03.blocksRaycasts = false;
        Canvas04.alpha = 0f;
        Canvas04.interactable = false;
        Canvas04.blocksRaycasts = false;
       
}
}

