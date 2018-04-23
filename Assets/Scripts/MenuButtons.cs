using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{

    [SerializeField] private AudioSource sfx;

    [SerializeField] private Menu menuManager;

    //----------------------------------
    //Menu Buttons
    public void ClickedPlayButton()
    {
        sfx.PlayDelayed(0);

        menuManager.MenuPanel.SetActive(!menuManager.MenuPanel.activeSelf);
        menuManager.PlayPanel.SetActive(!menuManager.PlayPanel.activeSelf);
    }

    public void ClickedSoundButton()
    {
        sfx.PlayDelayed(0);
    }

    public void ClickedControlsButton()
    {
        sfx.PlayDelayed(0);

        menuManager.TargetRotation = -75;

        menuManager.MenuPanel.SetActive(false);
        menuManager.ControlsPanel.SetActive(true);
    }

    public void ClickedCreditsButton()
    {
        StartCoroutine(WaitThenLoadScene(4));
    }

    public void ClickedQuitButton()
    {
        Application.Quit();
    }

    public void ClickedMenuButton()
    {
        StartCoroutine(WaitThenLoadScene(0));
    }

    public void ClickedBackButton()
    {
        sfx.PlayDelayed(0);

        menuManager.TargetRotation = 0;

        menuManager.MenuPanel.SetActive(true);
        menuManager.PlayPanel.SetActive(false);
        menuManager.ControlsPanel.SetActive(false);
        menuManager.SoundPanel.SetActive(false);
    }

    //--------------------------------------------
    //Planet Level Buttons
    
    public void LoadPlanetLevel(int sceneIndex)
    {
        StartCoroutine(WaitThenLoadScene(sceneIndex));
    }
    
    //--------------------------------------------
    private IEnumerator WaitThenLoadScene(int selectedScene)
    {
        sfx.PlayDelayed(0);

        yield return new WaitForSeconds(sfx.clip.length);

        SceneManager.LoadScene(selectedScene);

    }

}
