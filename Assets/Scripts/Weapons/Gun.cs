using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Gun : MonoBehaviour
{
    [SerializeField] private DinoHealth targetHealth;
    [SerializeField] private NavMeshAgent agent;

    [SerializeField] private Text reticle;
    [SerializeField] private float shootDistance;

    private AudioSource gunSFX;
    private void Start()
    {
        gunSFX = GetComponent<AudioSource>();
    }

    private void FixedUpdate ()
    {

        ShootRaycast();

        if (Input.GetButton("Fire1"))
        {
            gunSFX.UnPause();
        }
        else
        {
            gunSFX.Pause();
        }

    }

    private void ShootRaycast()
    {
        int layerMask = 1 << 9;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, shootDistance, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

            reticle.text = "❇";
            reticle.color = new Color(255, 0, 0);

            if (Input.GetButton("Fire1"))
            {
                targetHealth.Health --;

                agent.speed = 40;
            }
            else
            {
                agent.speed = 80;
            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * shootDistance, Color.white);

            reticle.text = "⊹";
            reticle.color = new Color(255, 255, 255);

            agent.speed = 80;

            gunSFX.Pause();
        }
    }
}
