using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory Singleton;
    public static InventoryItem carriedItem;

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
    }

    public void SpawnInventoryItem(Item item = null)
    {
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