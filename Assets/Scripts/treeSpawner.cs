using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreesSpawner : MonoBehaviour
{
    public GameObject trees;

    private float spawnRate = 8;
    private float heightOffset = 1;

    private float timer = 0;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            spawnTrees();
            timer = spawnRate;
        }
    }

    void spawnTrees()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(trees, new Vector3(transform.position.x, Random.Range(lowestPoint - 5, highestPoint + 10), 0), transform.rotation);
    }
}
