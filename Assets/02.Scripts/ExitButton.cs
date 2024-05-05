using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    AudioSource sound;

    private void Awake()
    {
        sound = GetComponent<AudioSource>();
    }
    public void OnButtonClick()
    {
        Debug.Log("�����մϴ�");
        Application.Quit();
    }
}
