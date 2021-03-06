﻿using System.Collections;
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

    public float TargetRotationY { get; set; }
    public float TargetRotationX { get; set; }
    //-----------------------------------

    // Use this for initialization
    void Start ()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        menuPanel.SetActive(true);
        playPanel.SetActive(false);
        controlsPanel.SetActive(false);
        SoundPanel.SetActive(false);

        camera.localEulerAngles = new Vector3(0, 0, 0);

        TargetRotationY = 0f;
        TargetRotationX = 0f;
	}

    private void Update()
    {
        CameraRotation();
    }

    private void CameraRotation()
    {
        float currentAngleY = camera.eulerAngles.y;
        float currentAngleX = camera.eulerAngles.x;

        float toAngleRotationY = Mathf.LerpAngle(currentAngleY, TargetRotationY, Time.deltaTime *2); //Calculate the lerp and speed for the the Y rotation
        float toAngleRotationX = Mathf.LerpAngle(currentAngleX, TargetRotationX, Time.deltaTime *2); //Calculate the lerp and speed for the the Y rotation


        camera.eulerAngles = new Vector3(toAngleRotationX, toAngleRotationY, 0); //Apply the lerp amount to desired angle
    }

}
