using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour {

    [SerializeField] private GameObject pauseMenu;

    [SerializeField] private GameObject winPanel;

    [SerializeField] private DinoHealth dinosaur;

    [SerializeField] private PlayerHealth player;

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
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            pauseMenu.SetActive(true);
        }

        if (dinosaur.Health <= 0)
        {
            SceneManager.LoadScene(0);
        }
        else if (player.PHealth <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
