using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Truck : MonoBehaviour {

    [SerializeField] Transform pointA, pointB;
    private int nextPoint;

    private NavMeshAgent truckAgent;

	// Use this for initialization
	void Start ()
    {
        truckAgent = GetComponent<NavMeshAgent>();

        GoToCheckPoint(0);
	}
	
    private void GoToCheckPoint(int nextCheckPoint)
    {
        switch (nextCheckPoint)
        {
            case 0:
                truckAgent.destination = pointA.position;
                nextPoint = 1;
                break;
            case 1:
                truckAgent.destination = pointB.position;
                nextPoint = 0;
                break;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {

            GoToCheckPoint(nextPoint);

        }
    }

}
