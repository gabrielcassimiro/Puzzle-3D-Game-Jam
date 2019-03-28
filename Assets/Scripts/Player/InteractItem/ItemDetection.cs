using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDetection : MonoBehaviour
{
    [SerializeField] private GameObject handSprite;
    [SerializeField] private string TagItemName;

    private void OnTriggerStay(Collider other) {
        if(other.CompareTag(TagItemName)){
            handSprite.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag(TagItemName)){
            handSprite.SetActive(false);
        }
    }
}
