using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour {

    private Animator saberAnimator;
    private MeshCollider meshCollider;

	private void Awake ()
    {
        saberAnimator = GetComponent<Animator>();
        meshCollider = GetComponent<MeshCollider>();
    }

    private void Start()
    {
        saberAnimator.SetBool("Attack", false);
        meshCollider.enabled = false;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            saberAnimator.SetBool("Attack", true);
            meshCollider.enabled = true;
        }
        else
        {
            saberAnimator.SetBool("Attack", false);
            meshCollider.enabled = false;
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Dinosaur")
        {
            other.gameObject.SetActive(false);

            GameManger2.Manager.TotalEnemies --;
        }
    }
}
