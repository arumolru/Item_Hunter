using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage2Button : MonoBehaviour
{
    private AudioSource sound;

    private void Awake()
    {
        sound = GetComponent<AudioSource>();
    }

    public void OnButtonClick()
    {
        Invoke("NextScene", 1f);
    }

    void NextScene()
    {
        sound.Play();
        SceneManager.LoadScene("Stage2");
    }
}
