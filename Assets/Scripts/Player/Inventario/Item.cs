using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Item 
{
    //a classe Item é uma classe abstrata, ou seja, não herda do Monobehavior. 
    //O que quer dizer que ela não tem código, ela só serve pra segurar propriedades.
    //Ela é o "modelo" do que um item deve ter, as instancias vão herdar dessa classe.

    public string itemName; //o nome do item
    public int itemID; //ID lógico do item
    public string itemDesc; //Uma breve descrição do item
    public Sprite itemIcon; // o icone 2D que vai ser exibido no inventário
    public GameObject itemModel; //o prefab do item

    public Item(string name, int id, string desc)
    {
        //Esse é o construtor da classe, serve para criar novos itens (pelo database)
        itemName = name;
        itemID = id;
        itemDesc = desc;
        itemIcon = Resources.Load<Sprite>("Icons/" + name);
        itemModel = Resources.Load<GameObject>("Models/" + name);
        //os campos de icone e de modelo 3D tem um caso especial, eles são carregados automaticamente, desde que estejam nas pastas certas
        //e os nomes estejam IDENTICOS ao nome dado ao item;
    }

    public Item()
    {
        //um construtor de item vazio. Ele serve para representar um slot sem nada.
        itemID = -1;
    }
    
    
}
