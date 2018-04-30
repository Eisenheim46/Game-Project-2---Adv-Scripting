using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour {

    [SerializeField] private GameObject pauseMenu;

    [SerializeField] private GameObject winPanel;

    [SerializeField] private DinoHealth dinosaur;

    // Use this for initialization
    void Start ()
    {
        pauseMenu.SetActive(false);
        winPanel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            pauseMenu.SetActive(true);
        }

        if (dinosaur.Health <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
