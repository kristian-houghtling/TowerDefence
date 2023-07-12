using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FindHome : MonoBehaviour
{
    public Transform destination;
    NavMeshAgent ai;

    // Start is called before the first frame update
    void Start()
    {
        ai = GetComponent<NavMeshAgent>();
        ai.SetDestination(destination.position);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
