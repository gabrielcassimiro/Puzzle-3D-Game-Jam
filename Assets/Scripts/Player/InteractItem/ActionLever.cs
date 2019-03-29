using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionLever : MonoBehaviour
{
    RaycastHit hit;
    Rigidbody rb;
    Vector3 movimento;

    public bool canClick;

    void Start () {
        rb = GetComponent<Rigidbody> ();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            canClick = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            canClick = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 50) && Input.GetMouseButton(0))
        {
            Vector3 playerToMouse = hit.point - transform.position;
            playerToMouse.y = 0;
            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            rb.MoveRotation(newRotation);
        }

    }

}
