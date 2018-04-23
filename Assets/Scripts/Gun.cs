using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{

    [SerializeField] private Text reticle;
    [SerializeField] private float shootDistance;
	
	// Update is called once per frame
	private void FixedUpdate ()
    {

        ShootRaycast();

    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicking");
        }
    }

    private void ShootRaycast()
    {
        int layerMask = 1 << 9;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, shootDistance, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            //Debug.Log("Did Hit");

            reticle.color = new Color(255, 0, 0);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * shootDistance, Color.white);
            //Debug.Log("Did not Hit");

            reticle.color = new Color(255, 255, 255);
        }
    }
}
