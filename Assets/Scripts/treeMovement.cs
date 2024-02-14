using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeMovement : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = 200;

    void Update()
    {
        transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
    }
}
