using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
private bool invhab; // Variavel para ligar e desligar o inventário na tela
GameObject inventoryPanel; // pega o inventário
GameObject slotPanel; // pega o panel onde ficam os slots
public GameObject inventorySlot; // o Objeto padrão Slot
public GameObject inventoryItem; // o frefab de item
public int slotAmount = 10; // quantidade de Slots
public List<Item> items = new List<Item>(); // a representação lógica dos itens nos slots no inventário.
public List<GameObject> slots = new List<GameObject>(); // A representação gráfica dos slots
private ItemDatabase database; // o database

void Start()
{
  database = GameObject.FindGameObjectWithTag("Database").GetComponent<ItemDatabase>();
  inventoryPanel = GameObject.Find("Inventario ");
  slotPanel = inventoryPanel.transform.Find("Slot Panel").gameObject;
  invhab = false;
  inventoryPanel.SetActive(invhab);

  for (int i = 0; i < slotAmount; i++) // coloca todos os slots, de acordo com a quantidade
  {
    items.Add(new Item()); //coloca um item vazio nos slots lógicos. 
    slots.Add(Instantiate(inventorySlot)); //coloca um slot no inventário.
    slots[i].transform.SetParent(slotPanel.transform); //coloca os slots na dentro do painel na hierarquia
    //desse jeito o slot[i] contém o items[i] e fica mais facil saber que item tem em que slot.
  }

}
void Update()
{
  if(Input.GetKeyDown(KeyCode.I)) //habilita e desabilita o inventário
  {
    invhab = !invhab;
    inventoryPanel.SetActive(invhab);
  }
  if(Input.GetButtonDown("Fire1"))
  {
    AddItemByID(0);
  }
  if(Input.GetButton("Jump"))
  {
    RemoveItemByID(0);
  }
}

public bool CanInventoryHold() // checa se tem espaço no inentário
{
  bool result = false;
  for (int i = 0; i < items.Count; i++)
  {
    if (items[i].itemID == -1)
    {
      result = true;
      break;
    }
  }
    if (!result)
    {
      Debug.Log("O Inventario está cheio!");
    }

  return result;
  }

public void AddItemByID(int id) // adiciona um item ao inventário por ID;
{
  if(CanInventoryHold())
  {
  for (int i = 0; i < items.Count; i++)
  {
    if(items[i].itemID == -1) //checa qual slot está vazio, para pegar o primeiro que estiver.
    {
      for (int j = 0; j < database.itens.Count; j++)
      {
        if(database.itens[j].itemID == id) //checa o banco de dados para saber qual item deve adicionar
        {
          items[i] = database.itens[j]; //adiciona o item no slot logico
          GameObject itemObj = Instantiate(inventoryItem, slots[i].transform); //adiciona o item no slot gráfico, na hierarquia.
          itemObj.GetComponent<Image>().sprite = database.itens[j].itemIcon; //seta a imagem do item. 
          break;
        }
      }
      break;
    }
  }
  }
}

public void RemoveItemByID(int id) // remove um item por ID
{
  for (int i = 0; i < items.Count; i++)
  {
      if(items[i].itemID == id) //checa qual dos itens no inventário corresponde ao que quer destruir, e pega o primeiro que achar.
      {
        items[i] = new Item(); //coloca um item vazio no slot lógico
        Destroy(slots[i].transform.GetChild(0).gameObject); //Destroi o item do slot gráfico, na hierarquia.
        break;
      }
  }
}

}
