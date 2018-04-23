using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    [Header("Panels")]
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject playPanel;
    [SerializeField] private GameObject controlsPanel;
    [SerializeField] private GameObject soundPanel;

    [Header("Camera")]
    [SerializeField] private Transform camera;


    //----------------------------------
    //Properties

    public GameObject MenuPanel { get { return menuPanel; } set { } }
    public GameObject PlayPanel { get { return playPanel; } set { } }
    public GameObject ControlsPanel { get { return controlsPanel; } set { } }
    public GameObject SoundPanel { get { return soundPanel; } set { } }

    public float TargetRotation { get; set; }
    //-----------------------------------

    // Use this for initialization
    void Start ()
    {
        menuPanel.SetActive(true);
        playPanel.SetActive(false);
        controlsPanel.SetActive(false);

        camera.localEulerAngles = new Vector3(0, 0, 0);

        TargetRotation = 0f;
	}

    private void Update()
    {
        CameraRotation();
    }

    private void CameraRotation()
    {
        float currentAngleY = camera.eulerAngles.y;

        float toAngleRotation = Mathf.LerpAngle(currentAngleY, TargetRotation, Time.fixedDeltaTime); //Calculate the lerp and speed for the the rotation

        camera.eulerAngles = new Vector3(0, toAngleRotation, 0); //Apply the lerp amount to desired angle
    }

}
