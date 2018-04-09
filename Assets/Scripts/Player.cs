using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Rigidbody rPlayer;

    [SerializeField] private CameraControls camera;

    [SerializeField] private float movementSpeed;

    private string verticalButtons = "Vertical";
    private string horizontalButtons = "Horizontal";

    private void Awake()
    {
        rPlayer = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        float vAxis = Input.GetAxis(verticalButtons);
        float hAxis = Input.GetAxis(horizontalButtons);

        if (Mathf.Abs(Input.GetAxis(horizontalButtons)) > 0 || Mathf.Abs(Input.GetAxis(verticalButtons)) > 0)
        {
            Vector3 movement = (transform.forward) * movementSpeed * vAxis * Time.deltaTime;
            Vector3 newAngles = transform.eulerAngles;

            newAngles.y = camera.CameraEulerAngleY;

            transform.eulerAngles = newAngles;
            rPlayer.MovePosition(rPlayer.position + movement);
        } 
    }
}
