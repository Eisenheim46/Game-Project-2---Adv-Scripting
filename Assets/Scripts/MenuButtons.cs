using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{

    [SerializeField] private AudioSource sfx;

    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject playPanel;

    public void ClickedPlayButton()
    {
        sfx.PlayDelayed(0);

        menuPanel.SetActive(!menuPanel.activeSelf);
        playPanel.SetActive(!playPanel.activeSelf);
    }

    public void ClickedSoundButton()
    {
        sfx.PlayDelayed(0);
    }

    public void ClickedControlsButton()
    {
        sfx.PlayDelayed(0);
    }

    public void ClickedCreditsButton()
    {

    }

    public void ClickedQuitButton()
    {
        Application.Quit();
    }

    public void ClickedMenuButton()
    {
        StartCoroutine(WaitThenLoadScene(0));
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
