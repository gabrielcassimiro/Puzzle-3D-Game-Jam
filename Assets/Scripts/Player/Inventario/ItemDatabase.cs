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

    public Item GetItemByID(int id)
    {
        for (int i = 0; i < itens.Count; i++)
        {
            if (id == itens[i].itemID)
            {
                return itens[i];
            }
        }
        Debug.Log("Não foi possivel encontrar o item");
        return null;
    }
     public Item GetItemByName(string nome)
    {
        for (int i = 0; i < itens.Count; i++)
        {
            if (nome == itens[i].itemName)
            {
                return itens[i];
            }
        }
        Debug.Log("Não foi possivel encontrar o item");
        return null;
    }

    public void PesquisarItem(int id)
    {
        Item item = GetItemByID(id);
        Debug.Log(item.itemName);
        Debug.Log(item.itemDesc);
    }

    public void PesquisarItem(string nome)
    {
        Item item = GetItemByName(nome);
        Debug.Log(item.itemID);
        Debug.Log(item.itemDesc);
    }
}
