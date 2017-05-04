using UnityEngine;
using System.Collections;

public class CanvasControl_ThirdTank : MonoBehaviour {
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
        Canvas01.alpha = 0f;
        Canvas01.interactable = false;
        Canvas01.blocksRaycasts = false;
        Canvas03.alpha = 0f;
        Canvas03.interactable = false;
        Canvas03.blocksRaycasts = false;
        Canvas04.alpha = 1f;
        Canvas04.interactable = true;
        Canvas04.blocksRaycasts = true;
    }
}
