using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramove : MonoBehaviour
{
    public Transform playerTransform;

    private void Update()
    {
        Vector3 vec = new Vector3(0, -2, 5);

        transform.position = playerTransform.position-vec;
    }
}
