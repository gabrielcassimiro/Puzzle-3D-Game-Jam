using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    private Renderer book;

    private void Start()
    {
        book = GetComponent<MeshRenderer>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Livro"))
        {
            if (Input.GetMouseButtonUp(0))
            {
                book.enabled = true;
                //bool da porta setado pra true E fazer a animação rodar
            }
        }   
    }
}
