using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventario : MonoBehaviour
{
    public GameObject inventário;
    private bool invhab;

    private int allslots;
    private int habslots;
    private GameObject[] slot;

    public GameObject Slots;

    void Start()
    {
        allslots = 9;
        slot = new GameObject[allslots];

        for (int i = 0; i < allslots; i++)
        {
            slot[i] = Slots.transform.GetChild(i).gameObject;
        }
    }
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.I))
            invhab = !invhab;
      if(invhab == true)
        {
        inventario.SetActive(true);
        }
      else
        {
        inventario.SetActive(false);
        }
    }
}
