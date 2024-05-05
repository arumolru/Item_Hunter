using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public GameObject pauseCanvas;
    bool pauseButton = false;
    public void OnButtonClick()
    {
        if (pauseButton==false)
        {
            pauseCanvas.SetActive(true);
            pauseButton = true;
        }
        else
        {
            pauseCanvas.SetActive(false);
            pauseButton = false;
        }
    }
}
