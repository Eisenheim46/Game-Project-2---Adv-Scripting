using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicButtons : MonoBehaviour {

    [SerializeField] private GameObject[] panel;

    //------------------------
    //Credits Buttons
    public void NextButtonClicked()
    {
        panel[0].SetActive(!panel[0].activeSelf);
        panel[1].SetActive(!panel[1].activeSelf);
    }

    //------------------------

    //------------------------
    //Pause Buttons

    public void ContinueButtonClicked()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        panel[0].SetActive(false);
    }

    //------------------------


    public void MenuButtonClicked()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitButtonClicked()
    {
        Application.Quit();
    }
}
