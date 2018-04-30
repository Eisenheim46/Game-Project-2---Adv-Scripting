using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] private CameraControls camera;

    [SerializeField] private float movementSpeed;

    [SerializeField] private bool hasFullMovement;
    [SerializeField] private bool hasSideMovement;

    private Rigidbody rPlayer;

    private string verticalButtons = "Vertical";
    private string horizontalButtons = "Horizontal";

    private void Awake()
    {
        rPlayer = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        if (hasFullMovement)
            FullMove();
        else if (hasSideMovement)
            SideMove();
            
    }


    private void FullMove()
    {
        float vDirection = Input.GetAxis(verticalButtons);
        float hDirection = Input.GetAxis(horizontalButtons);

        if (Mathf.Abs(Input.GetAxis(horizontalButtons)) > 0 || Mathf.Abs(Input.GetAxis(verticalButtons)) > 0)
        {
            Vector3 movement = (transform.forward) * movementSpeed * vDirection * Time.deltaTime; //On what blue axis * how fast * direction * realtime seconds
            Vector3 sideMovement = (transform.right) * movementSpeed * hDirection * Time.deltaTime;//Same as above but on the red axis
            Vector3 newAngles = transform.eulerAngles; //Handle rotation of the player

            newAngles.y = camera.CameraEulerAngleY; //Change only the Y rotation on the V3
            transform.eulerAngles = newAngles;// Insert whole V3 rotation change to the character

            rPlayer.MovePosition(rPlayer.position + movement + sideMovement);//Move the character forward from its position
        }
    }

    private void SideMove()
    {
        float hDirection = Input.GetAxis(horizontalButtons);

        if (Mathf.Abs(Input.GetAxis(horizontalButtons)) > 0 || Mathf.Abs(Input.GetAxis(verticalButtons)) > 0)
        {
            Vector3 sideMovement = (transform.right) * movementSpeed * hDirection * Time.deltaTime;//Same as above but on the red axis
            Vector3 newAngles = transform.eulerAngles; //Handle rotation of the player

            //newAngles.y = camera.CameraEulerAngleY; //Change only the Y rotation on the V3
           // transform.eulerAngles = newAngles;// Insert whole V3 rotation change to the character

            rPlayer.MovePosition(rPlayer.position + sideMovement);//Move the character forward from its position
        }
    }
}
