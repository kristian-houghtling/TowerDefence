using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FindHome : MonoBehaviour
{
    public Transform destination;
    NavMeshAgent ai;


    void Start()
    {
        ai = GetComponent<NavMeshAgent>();
        if (destination != null)
        {
            ai.SetDestination(destination.position);
        }
        else
        {
            Debug.LogError("Destination is null!");
        }
    }


    void Update()
    {
        if (ai.remainingDistance < 0.5f && ai.hasPath)
        {
            LevelManager.RemoveEnemy();
            ai.ResetPath();
            Destroy(this.gameObject, 0.1f);
        }
    }
}
