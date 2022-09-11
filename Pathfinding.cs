using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathfinding : MonoBehaviour
{
    public Transform[] points;

    private NavMeshAgent nav;
    private int destPoint;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>(); //get reference from navmesh agent
    }

    void FixedUpdate()
    {
        if (!nav.pathPending && nav.remainingDistance < 0.5f) // check is object if object reach destination
            GoToNextPoint(); 
    }

    void GoToNextPoint() //find the next point to travel
    {
        if (points.Length == 0)
        {
            return;
        }

        nav.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;
    }
}
