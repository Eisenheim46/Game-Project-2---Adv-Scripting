using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TRex : MonoBehaviour {

    [SerializeField]private Transform targetPlayer;

    private NavMeshAgent rexyAgent;

    //----------------
    //Properties

    private int health;

    //----------------

	// Use this for initialization
	void Start ()
    {
        rexyAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        rexyAgent.SetDestination(targetPlayer.position);
	}
}
