using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory Singleton;
    public static InventoryItem carriedItem;
    private escmenu esc;

    [SerializeField] InventorySlot[] inventorySlots;

    [SerializeField] Transform draggablesTransform;
    [SerializeField] InventoryItem itemPrefab;

    [Header("Item List")]
    [SerializeField] Item[] items;

    [Header("Debug")]
    [SerializeField] Button giveItemButon;

    void Awake()
    {
        Singleton = this;
        giveItemButon.onClick.AddListener(delegate {SpawnInventoryItem();});
        esc = FindObjectOfType<escmenu>();
    }

    public void SpawnInventoryItem(Item item = null)
    {
        if (items.Length == 0)
        {
            Debug.LogWarning("No items in the 'items' array.");
            return;
        }

        Item _item = item;
        if(_item == null)
        {
            int random = Random.Range(0, items.Length);
            _item = items[random];
        }

        for (int i = 0; i < inventorySlots.Length; i++)
        {
            //Check if the slot is empty
            if(inventorySlots[i].myItem == null)
            {
                Instantiate(itemPrefab, inventorySlots[i].transform).Initialize(_item, inventorySlots[i]);
                break;
            }
        }
    }


    public void GetKnife()
    {
        List<Item> knifeItems = new List<Item>();
        foreach (Item item in items)
        {
            if (item.itemTag == SlotTag.Knife) {knifeItems.Add(item);}
        }
        Item selectedKnifeItem = knifeItems[Random.Range(0, knifeItems.Count)];

        SpawnInventoryItem(selectedKnifeItem);
        esc.OpenEscapeMenu();
    }


    public void GetCardboard()
    {
        List<Item> cardboardGet = new List<Item>();
        foreach (Item item in items)
        {
            if (item.itemTag == SlotTag.CardBoard) {cardboardGet.Add(item);}
        }
        Item selectedCardBoardItem = cardboardGet[Random.Range(0, cardboardGet.Count)];

        SpawnInventoryItem(selectedCardBoardItem);
    }



    void Update()
    {
        if(carriedItem == null) return;

        carriedItem.transform.position=Input.mousePosition;
    }
    
    public void SetCarriedItem(InventoryItem item)
    {
        if(carriedItem != null)
        {
            if(item.activeSlot.myTag != SlotTag.None && item.activeSlot.myTag != carriedItem.myItem.itemTag) return;
            item.activeSlot.SetItem(carriedItem);
        }

        if(item.activeSlot.myTag != SlotTag.None)
        { EquipEquipment(item.activeSlot.myTag, null); }

        carriedItem = item;
        carriedItem.canvasGroup.blocksRaycasts = false;
        item.transform.SetParent(draggablesTransform);
    }


    public void EquipEquipment(SlotTag tag, InventoryItem item = null)
    {
        switch (tag)
        {

        case SlotTag.Knife:
            if(item == null)
            {
                //Destroy item.equipmentPrefab on the Player Object
                IsKnifeHolding = false;
                Debug.Log("Unequipped Knife on " + tag);
            }
            else 
            {
                //Instantiate item.equippmenPrefab on the Player Object
                IsKnifeHolding = true;
                Debug.Log("Equipped " + item.myItem.name + "on " + tag);
            }
            break;
        }
    }

    public bool IsKnifeHolding = false;

}