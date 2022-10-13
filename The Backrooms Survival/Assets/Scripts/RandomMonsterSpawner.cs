using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMonsterSpawner : MonoBehaviour
{
    public GameObject monster;
    public Transform spawnPoint;
    public float maxX;
    public float maxZ;

    void Start()
    {
        InvokeRepeating("SpawnObject", 10f, 10f);
    }
    void SpawnObject()
    {
        float randomX = Random.Range(-maxX, maxX);
        float randomZ = Random.Range(-maxZ, maxZ);
        Vector3 randomSpawnPos = new Vector3(randomX, 3f, randomZ);
        Instantiate(monster, randomSpawnPos, Quaternion.identity);
    }
}
