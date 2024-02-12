using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bikersMovement : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = 200;

    void Update()
    {
        transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;

    }
}
