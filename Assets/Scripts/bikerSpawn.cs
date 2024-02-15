using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bikerSpawn : MonoBehaviour
{
    public GameObject biker01;
    public GameObject biker02;
    public GameObject biker03;

    private float spawnRate = 10;
    private float heightOffset = 10;

    private float timer = 0;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            spawnBiker();
            timer = spawnRate;
        }
    }

    void spawnBiker()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(biker01, new Vector3(transform.position.x, Random.Range(lowestPoint - 10, highestPoint + 20), 0), transform.rotation);
        Instantiate(biker02, new Vector3(transform.position.x, Random.Range(lowestPoint - 30, highestPoint + 30), 0), transform.rotation);
        Instantiate(biker03, new Vector3(transform.position.x, Random.Range(lowestPoint - 40, highestPoint + 40), 0), transform.rotation);
    }

}