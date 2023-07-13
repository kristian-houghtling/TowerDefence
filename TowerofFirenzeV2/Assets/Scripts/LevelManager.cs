using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    GameObject[] spawnedEnemies;
    static int maxEnemies = 0;


    void Start()
    {
        spawnedEnemies = GameObject.FindGameObjectsWithTag("spawn");
        foreach (GameObject enemy in spawnedEnemies)
        {
            maxEnemies += enemy.GetComponent<Spawner>().maxEnemies;
        }
    }

    public static void RemoveEnemy()
    {
        maxEnemies--;
        if (maxEnemies <= 0)
        {
            Debug.Log("Level Over!");
        }
    }



}
