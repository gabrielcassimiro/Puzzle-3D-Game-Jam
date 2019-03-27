using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> itens = new List<Item>(); 
    // Uma lista do tipo Items (clase abstrata)

    private void Start() 
    {
        //itens.Add(new Item("", itens.Count, "")); //Construtor padrão da classe Item
        itens.Add(new Item("Livro", itens.Count, "Um livro"));

    }
}
