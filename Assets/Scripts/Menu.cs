using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject playPanel;

    // Use this for initialization
    void Start ()
    {
        menuPanel.SetActive(true);
        playPanel.SetActive(false);
	}
}
