using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageAllClearButton : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Lobby");
    }
}
