using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TRex : MonoBehaviour {

    [SerializeField] private Transform targetPlayer;

    private AudioSource roarSFX;

    private NavMeshAgent rexyAgent;

	// Use this for initialization
	void Start ()
    {
        rexyAgent = GetComponent<NavMeshAgent>();
        roarSFX = GetComponent<AudioSource>();
	}

    // Update is called once per frame
    void LateUpdate()
    {
        rexyAgent.SetDestination(targetPlayer.position);

        if (Time.fixedTime % 11 == 10)
        {
            roarSFX.PlayDelayed(0);
        }
    }
}
