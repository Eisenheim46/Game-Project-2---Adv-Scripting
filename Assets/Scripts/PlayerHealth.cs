using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    [SerializeField] private int pHealth;
    [SerializeField] private Slider healthSlider;

    //----------------
    //Properties
    public int PHealth { get { return pHealth; } set { pHealth = value; healthSlider.value = value; } }

    //----------------
}
