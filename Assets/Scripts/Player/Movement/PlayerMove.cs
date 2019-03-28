using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private string horizontalInputName, verticalInputName;
    private Animator anim;

    [SerializeField] private float movementSpeed;

    private CharacterController charController;

    private void Awake() {
        charController = GetComponent<CharacterController>();
        anim = this.GetComponent<Animator>();
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
        if(horizInput > 0 || horizInput < 0){
            anim.SetBool("Walk", true);
        } 
        if(verInput > 0 || verInput < 0){
            anim.SetBool("Walk", true);
        }        
        else if(verInput == 0 || horizInput == 0){
            anim.SetBool("Walk", false);
        }
    }
}
