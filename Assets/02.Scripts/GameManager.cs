using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pauseCanvas;
    private void Awake()
    {
        pauseCanvas.SetActive(false);
    }
}
