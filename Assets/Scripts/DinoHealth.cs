using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DinoHealth : MonoBehaviour {

    [SerializeField] private int health;
    [SerializeField] private Slider healthSlider;

    //----------------
    //Properties
    public int Health { get { return health; } set { health = value; healthSlider.value = value; } }

    //----------------
}
