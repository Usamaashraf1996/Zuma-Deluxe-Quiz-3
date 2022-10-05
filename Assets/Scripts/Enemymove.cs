using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemymove : GameManager
{
   
    NavMeshAgent agent;
    public Transform[] wayPoints;
    int waypointIndex;
    Vector3 target;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        Updatedestination();
    }
    private void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5) { 
        
        Updatedestination();
            Iteratewaypointindex();
        }
      
    }
    void Updatedestination()
    {

        target = wayPoints[waypointIndex].position;
        agent.destination = wayPoints[waypointIndex].position;
        
    }
    void Iteratewaypointindex()
    {
        waypointIndex++;
        if (waypointIndex == wayPoints.Length)
        {
            waypointIndex = 0;
        }
    }
}

