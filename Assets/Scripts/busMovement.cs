using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class busMovement : MonoBehaviour
{
    [SerializeField] private float floatSpeed = 10f; // Speed of floating
    [SerializeField] private float floatHeight = 20f; // Height of floating

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Calculate the new Y position using a sine wave
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        // Update the object's position
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
