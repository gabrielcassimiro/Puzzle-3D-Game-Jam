using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class ItemDetection : MonoBehaviour
{
    [SerializeField] private GameObject handSprite, bookObject, bookObject2;
    public MeshRenderer Book2;

    public Animator animExitBook;

    public GameObject  macanetaObject, macanetaObject2;
    public MeshRenderer macaneta2;
    public Animator opendoor;

    public Animator Btn;

    [SerializeField] private string TagItemName;

    [SerializeField] private bool book, macaneta, alavanca;

    private void OnTriggerStay(Collider other) {
        if(other.CompareTag(TagItemName)){
            handSprite.SetActive(true);
        }

        if(other.CompareTag("Book")){
            handSprite.SetActive(true);
            if(!book){
                if(Input.GetKeyDown(KeyCode.E)){
                    book = true;
                    bookObject.SetActive(false);
                    handSprite.SetActive(false);
                }
            }
        }

        if(other.CompareTag("Book2")){
            handSprite.SetActive(true);
            if(book){
                if(Input.GetKeyDown(KeyCode.E)){
                    Book2.enabled = true;
                    handSprite.SetActive(false);
                    animExitBook.Play("Passagem Secreta");
                }
            }
        }

        if(other.CompareTag("Macaneta")){
            if(!macaneta){
                handSprite.SetActive(true);
                if(Input.GetKeyDown(KeyCode.E)){
                    macanetaObject.SetActive(false);
                    macaneta = true;
                    handSprite.SetActive(false);
                }
            }
        }

        if(other.CompareTag("Macaneta2")){
            if(macaneta){
                handSprite.SetActive(true);
                if(Input.GetKeyDown(KeyCode.E)){
                    handSprite.SetActive(false);
                    macaneta2.enabled = true;
                    handSprite.SetActive(false);
                    opendoor.Play("OpenDoor");
                }
            }
        }
        
        if(other.CompareTag("Btn")){
            if(!alavanca){
                handSprite.SetActive(true);
                if(Input.GetKeyDown(KeyCode.E)){
                    alavanca = true;
                    Btn.Play("´Button");
                    handSprite.SetActive(false);
                }
            }
        }

        if(other.CompareTag("Btn2")){
            if(alavanca){
                handSprite.SetActive(true);
                if(Input.GetKeyDown(KeyCode.E)){
                    SceneManager.LoadScene("Menu");
                    
                }
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag(TagItemName)){
            handSprite.SetActive(false);
        }
        if(other.CompareTag("Macaneta")){
            handSprite.SetActive(false);
        }
        if(other.CompareTag("Macaneta2")){
            handSprite.SetActive(false);
        }
        if(other.CompareTag("Book")){
            handSprite.SetActive(false);
        }
        if(other.CompareTag("Book2")){
            handSprite.SetActive(false);
        }
        if(other.CompareTag("Btn")){
            handSprite.SetActive(false);
        }
    }
}
