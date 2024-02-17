using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnCollision : MonoBehaviour
{
    public string sceneToLoad; 


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("test");

        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

}