using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform homeLocation;
    public float spawnRate = 0.3f;
    public int maxEnemies = 10;
    public float spawnDelay = 1.0f;
    int enemiesSpawned = 0;


    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnRate);
    }

    void SpawnEnemy()
    {
        GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        FindHome fh = enemy.GetComponent<FindHome>();
        fh.destination = homeLocation;
        enemiesSpawned++;
        if (enemiesSpawned >= maxEnemies)
        {
            CancelInvoke("SpawnEnemy");
        }
    }


}
