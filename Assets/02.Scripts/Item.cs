using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(1, 1, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="PLAYER")
        {
            gameObject.SetActive(false);
        }
    }
}
