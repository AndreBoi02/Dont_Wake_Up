using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowTheLight : Interactable
{
    NavMeshAgent agent;

    public Transform[] spawnPoints;

    int cycles = 0;
    int currentPoint = 0;
    int lastPoint = 7;

    public override void OnInteraction()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        if (cycles < 3)
        {
            currentPoint = Random.Range(1, spawnPoints.Length);
            if (currentPoint != lastPoint)
            {
                agent.SetDestination(spawnPoints[currentPoint].position);
                lastPoint = currentPoint;
            }
            cycles += 1;
        }
        else
        {
            GetComponent<Dropper>().Drop(transform.position);
            Destroy(gameObject);
        }
    }
}
