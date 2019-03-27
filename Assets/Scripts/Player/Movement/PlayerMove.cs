using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private string horizontalInputName, verticalInputName;

    [SerializeField] private float movementSpeed;

    private CharacterController charController;

    private void Awake() {
        charController = GetComponent<CharacterController>();
    }

    private void Update() {
        playerMovement();
    }

    private void playerMovement(){
        float horizInput = Input.GetAxis(horizontalInputName) * movementSpeed;
        float verInput = Input.GetAxis(verticalInputName) * movementSpeed;

        Vector3 forwardMove = transform.forward * verInput;
        Vector3 rightMove = transform.right * horizInput;

        charController.SimpleMove(forwardMove + rightMove);
    }
}
