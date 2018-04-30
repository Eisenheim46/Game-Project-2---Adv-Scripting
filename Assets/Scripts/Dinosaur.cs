using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Dinosaur : MonoBehaviour {

    private NavMeshAgent agent;

    [SerializeField] private Transform[] navPoints;

    [SerializeField] private int maxPoints;

    private int randomIndex;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        randomIndex = Random.Range(0, maxPoints);

        if (randomIndex > 3)
        {
            randomIndex = 3;
        }

        agent.SetDestination(navPoints[randomIndex].position);
       
    }

    // Update is called once per frame
    void Update ()
    {
		if (Time.fixedTime % 11 == 10)
        {
            randomIndex = Random.Range(0, maxPoints);

            if (randomIndex > 3)
            {
                randomIndex = 3;
            }

            agent.SetDestination(navPoints[randomIndex].position);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Dinosaur")
        {
            randomIndex = Random.Range(0, maxPoints);

            if (randomIndex > 3)
            {
                randomIndex = 3;
            }

            agent.SetDestination(navPoints[randomIndex].position);
        }
    }
}