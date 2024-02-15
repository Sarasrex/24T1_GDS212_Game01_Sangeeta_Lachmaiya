using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyArea : MonoBehaviour
{

    public GameObject gameObject;

    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has a tag "Destroyer"
        if (collision.gameObject.CompareTag("Destroyer"))
        {
            // Destroy the game object this script is attached to
            Destroy(gameObject);
        }
    }

}
