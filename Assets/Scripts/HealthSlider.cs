using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSlider : MonoBehaviour {

    [SerializeField] private Camera main;

	// Update is called once per frame
	void LateUpdate ()
    {
        transform.LookAt(main.transform);
    }
}
