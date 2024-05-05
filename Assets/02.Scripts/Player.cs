using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public int jumpForce = 5;
    public int moveSpeed = 10;
    public int stageLevel;
    bool isJump = false;

    AudioSource sound;

    private int point = 0;
    public int itemCount;
    public GameObject clearUI;
    void Awake()
    {
        rb=GetComponent<Rigidbody>();
        sound = GetComponent<AudioSource>();
        clearUI.SetActive(false);
    }

    void Update()
    {      
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJump = true;
        }
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(h * moveSpeed * Time.deltaTime, 0, v * moveSpeed * Time.deltaTime);

        rb.AddForce(vec, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="GROUND")
        {
            isJump = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FALLOUT")
        {
            SceneManager.LoadScene("Stage" + stageLevel.ToString());
        }

        else if (other.gameObject.tag == "ITEM")
        {
            point++;
            sound.Play();
            Debug.Log(point);
        }

        else if (other.gameObject.tag == "GOAL" && point == itemCount)
        {
                gameObject.SetActive(false);
                clearUI.SetActive(true);
        }
    }
}
