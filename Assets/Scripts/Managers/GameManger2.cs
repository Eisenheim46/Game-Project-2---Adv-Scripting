using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger2 : MonoBehaviour {

    public static GameManger2 Manager;

    [SerializeField] private GameObject pauseMenu;

    [SerializeField] private GameObject winPanel;

    [SerializeField] private int totalEnemies = 4;

    public int TotalEnemies { get { return totalEnemies; } set { totalEnemies = value; } }

    private void Awake()
    {
        if (Manager == null)
        {
            Manager = this;
        }

        else if (Manager != this)
        {
            Destroy(gameObject);
        }
    }

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

        if (totalEnemies <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
