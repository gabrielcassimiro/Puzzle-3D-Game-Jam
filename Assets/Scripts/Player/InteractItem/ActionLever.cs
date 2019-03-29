using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionLever : MonoBehaviour
{
    /*
    RaycastHit hit;
    Rigidbody rb;
    Vector3 movimento;
    */
    public float rot;
    public bool canClick;

    void Start () {
        //rb = GetComponent<Rigidbody> ();
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
        if (Input.GetMouseButton(0) && rot >= -0.2802625f)
        {
            rot = (gameObject.transform.rotation.x - Input.mousePosition.x) * 0.0005f;
            gameObject.transform.Rotate(rot, 0f, 0f);
        }
    }
    private void verificar()
    {
        if(rot >= -0.2802625f)
        {
            //ALGUM CODIGO PRA DESTRAVAR O BOOL DE OUTRO CODIGO PRA FAZER A PORTA ABRIR
        }
    }

}
