using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    AudioSource sound;

    private void Awake()
    {
        sound = GetComponent<AudioSource>();
    }

    public void OnButtonClick()
    {
        sound.Play();
        Invoke("NextStage", 1f);
    }

    void NextStage()
    {
        SceneManager.LoadScene("Stage1");
    }
}
