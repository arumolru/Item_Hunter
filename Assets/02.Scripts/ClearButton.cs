using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearButton : MonoBehaviour
{
    public int stageLevel;
    public GameObject player;

    public void OnButtonClick()
    {
        SceneManager.LoadScene("Stage" + stageLevel + 1.ToString());
        player.SetActive(true);
    }
}
