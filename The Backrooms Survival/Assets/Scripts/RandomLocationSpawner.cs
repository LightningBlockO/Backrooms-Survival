using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLocationSpawner : MonoBehaviour
{
    public GameObject wall;
    public GameObject wall2;
    public Transform spawnPoint;
    public float maxX;
    public float maxZ;

    void Start()
    {
        //InvokeRepeating("SpawnObject", 0f, 0f);
        for (int i = 0; i < 50; i++)
        {
            SpawnObject1();
            SpawnObject2();
        }
    }
    void SpawnObject1()
    {
        float randomX = Random.Range(-maxX, maxX);
        float randomZ = Random.Range(-maxZ, maxZ);
        Vector3 randomSpawnPos = new Vector3(randomX, 3f, randomZ);
        Instantiate(wall, randomSpawnPos, Quaternion.identity);
    }
    void SpawnObject2()
    {
        float randomX = Random.Range(-maxX, maxX);
        float randomZ = Random.Range(-maxZ, maxZ);
        Vector3 randomSpawnPos = new Vector3(randomX, 3f, randomZ);
        Instantiate(wall2, randomSpawnPos, wall2.transform.rotation);
    }
}