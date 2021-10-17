using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject firstCanvas;
    [SerializeField] private GameObject secondCanvas;

    private GameObject currentCanvas;

    private void Start()
    {
        firstCanvas.SetActive(true);
        currentCanvas = firstCanvas;
    }

    public void ChangePannel (GameObject pannel)
    {
        if (currentCanvas != null)
        {
            currentCanvas.SetActive(false);
            pannel.SetActive(true);
            currentCanvas = pannel;
        }
        
    }
}
