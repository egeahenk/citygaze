using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEditor;

public class containergeneral : MonoBehaviour
{
    public SpriteRenderer spri;
    public Sprite closedContainer;
    public Sprite openContainer;

    public bool isCollected = false;
    public bool isTriggered = false;

    private escmenu esc;
    private Inventory inv;

    [SerializeField] InventoryItem itemPrefab;

    private void Awake()
    {
        inv = FindObjectOfType<Inventory>();
        esc = FindObjectOfType<escmenu>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.R) && !isCollected && isTriggered)
        {
            Debug.Log("R Key");
            OpenContainer();
            isCollected = true;
            GetCardboard();
        }else return;
    }

public void GetCardboard()
{
    esc.OpenEscapeMenu();

    Item[] inventoryItems = inv.GetItems();
    InventorySlot[] inventorySlots = inv.GetInventorySlots();
    
    if (inventoryItems.Length == 0)
    {
        Debug.LogWarning("No items in the 'items' array.");
        return;
    }

    List<Item> cardboardItems = new List<Item>();
    foreach (Item item in inventoryItems)
    {
        if (item.itemTag == SlotTag.cardboard)
        {
            cardboardItems.Add(item);
        }
    }

    if (cardboardItems.Count == 0)
    {
        Debug.LogWarning("No items with 'cardboard' tag in the 'items' array.");
        return;
    }

    int random = Random.Range(0, cardboardItems.Count);
    Item selectedcardboardItem = cardboardItems[random];

    for (int i = 0; i < inventorySlots.Length; i++)
    {
        if (inventorySlots[i].myItem == null)
        {
            Instantiate(itemPrefab, inventorySlots[i].transform).Initialize(selectedcardboardItem, inventorySlots[i]);
            break;
        }
    }
}

    
/*
        if (other.CompareTag("Player") && !isCollected)
        {
            if(Input.GetKey(KeyCode.R))
            {
            Debug.Log("R Key");
            OpenContainer();
            isCollected = true;
            }else Debug.Log("Key Skipped"); return;
        }
*/
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {isTriggered = true;}
    }





    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("Player")) {CloseContainer(); isTriggered = false;}    
    }

    void OpenContainer()
    {
        Debug.Log("OpenContainer Activated");
        spri.sprite = openContainer;
    }

    void CloseContainer()
    {
        Debug.Log("CloseContainer Activated");
        spri.sprite = closedContainer;
    }

}