﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

    [SerializeField] private float cameraSpeed;

    [SerializeField] private float maxClamp;
    [SerializeField] private float minClamp;

    private string mouseAxisY = "Mouse Y";
    private string mouseAxisX = "Mouse X";

    private float yRotation;
    private float xRotation;

    public float CameraEulerAngleY { get { return transform.eulerAngles.y; } }

    private void LateUpdate()
    {
        yRotation += Input.GetAxis(mouseAxisX) * cameraSpeed;
        xRotation -= Input.GetAxis(mouseAxisY) * cameraSpeed;

       xRotation = Mathf.Clamp(xRotation, minClamp, maxClamp);

        Debug.Log(xRotation);

        transform.eulerAngles = new Vector3(xRotation, yRotation, 0);
    }
}
