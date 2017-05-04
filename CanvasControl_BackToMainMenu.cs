using UnityEngine;
using System.Collections;

public class CanvasControl_BackToMainMenu : MonoBehaviour
{

    [SerializeField]
    private CanvasGroup Canvas01;
    [SerializeField]
    private CanvasGroup Canvas02;
    [SerializeField]
    private CanvasGroup Canvas03;
    [SerializeField]
    private CanvasGroup Canvas04;



    public void OnButtonClick()
    {
        Canvas02.alpha = 0f;
        Canvas02.interactable = false;
        Canvas02.blocksRaycasts = false;
        Canvas01.alpha = 1f;
        Canvas01.interactable = true;
        Canvas01.blocksRaycasts = true;
        Canvas03.alpha = 0f;
        Canvas03.interactable = false;
        Canvas03.blocksRaycasts = false;
        Canvas04.alpha = 0f;
        Canvas04.interactable = false;
        Canvas04.blocksRaycasts = false;
    }
}
