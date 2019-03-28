using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int id; // o id do item a ser instanciado
    private ItemDatabase database;

    // Start is called before the first frame update
    void Start()
    {
        database = GameObject.FindGameObjectWithTag("Database").GetComponent<ItemDatabase>();
        Item item = database.GetItemByID(id); //Pega o item no database pelo ID;
        Instantiate(item.itemModel, this.transform.position, this.transform.rotation); //Pega o modelo salvo no database e instancia
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
