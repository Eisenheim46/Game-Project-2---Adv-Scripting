using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour {


    [SerializeField] PlayerHealth player;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Dinosaur")
        {
            player.PHealth -= 1;
        }
    }

}
