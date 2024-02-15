using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeepleSpawner : MonoBehaviour
{
    public GameObject meeple;

    private float spawnRate = 8;
    private float heightOffset = 10;

    private float timer = 0;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            spawnMeeple();
            timer = spawnRate;
        }
    }

    void spawnMeeple()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(meeple, new Vector3(transform.position.x, Random.Range(lowestPoint - 10, highestPoint + 20), 0), transform.rotation);
    }
}