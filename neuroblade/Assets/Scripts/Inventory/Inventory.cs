using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory Singleton;
    public static InventoryItem carriedItem;
    private escmenu esc;

    public bool IsKnifeHolding = false;

    [SerializeField] InventorySlot[] inventorySlots;
    [SerializeField] InventoryItem itemPrefab;
    
    [SerializeField] Transform draggablesTransform;
/*
    [SerializeField] DragTest dragtest;*/

    [Header("Item List")]
    [SerializeField] Item[] items;

    [Header("Debug")]
    [SerializeField] Button giveItemButton;


    void Awake()
    {
        Singleton = this;
    }

    void Update()
    {
        if(carriedItem == null) return;

        carriedItem.transform.position = Input.mousePosition;
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
                if (item == null)
                {
                    // Destroy item.equipmentPrefab on the Player InventoryItemect
                    IsKnifeHolding = false;
                    Debug.Log("Unequipped Knife on " + tag);
                }
                else
                {
                    // Instantiate item.equipmentPrefab on the Player InventoryItemect
                    IsKnifeHolding = true;
                    Debug.Log("Equipped " + item.myItem.name + " on " + tag);
                }
                break;
        }
    }
    public Item[] GetItems()
    {
        return items;
    }

    public InventorySlot[] GetInventorySlots()
    {
        return inventorySlots;
    }



/*    void Awake()
    {
        dragtest.Toggle(false);
        Singleton = this;
        esc = FindObjectOfType<escmenu>();
    }



    public Sprite sprite;


    public void SpawnInventoryItem(Item item = null)
    {
        if (items.Length == 0)
        {
            Debug.LogWarning("No items in the 'items' array.");
            return;
        }

        Item _item = item;
        if (_item == null)
        {
            int random = Random.Range(0, items.Length);
            _item = items[random];
        }

        for (int i = 0; i < inventorySlots.Length; i++)
        {
            // Check if the slot is empty
            if (inventorySlots[i].myItem == null)
            {
                InventoryItem newItem = Instantiate(itemPrefab, inventorySlots[i].transform);
                newItem.Initialize(_item, inventorySlots[i]);
                break;
            }
        }
    }

    void Update()
    {
        if (carriedItem == null) return;

        carriedItem.transform.position = Input.mousePosition;
    }

/*          
            iitem.transform.SetParent(game);
            items.Add(iitem);
*/
/*
    public void InitializeInventory(int inventorysize)
    {
        for(int i = 0; i < inventorysize; i++)
        {
            InventoryItem iitem = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
            iitem.OnItemClicked += HandleItemSelection;
            iitem.OnItemBeginDragged += HandleBeginDrag;
            iitem.OnItemDropped += HandleSwap;
            iitem.OnItemEndDrag += HandleEndDrag;
            iitem.OnRightMouseBtnClick += HandleShowItemActions;
        }
    }

    public void HandleShowItemActions(InventoryItem InventoryItem)
    {

    }

    public void HandleEndDrag(InventoryItem InventoryItem)
    {
        dragtest.Toggle(false);
    }


    public void HandleSwap(InventoryItem InventoryItem)
    {

    }


    public void HandleBeginDrag(InventoryItem InventoryItem)
    { 

        dragtest.Toggle(true);
        dragtest.SetData(InventoryItem.myItem.sprite);
    }

    public void HandleItemSelection(InventoryItem InventoryItem)
    {
        
    }
*/
/*
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
*/
/*    public void EquipEquipment(SlotTag tag, InventoryItem item = null)
    {
        switch (tag)
        {
            case SlotTag.Knife:
                if (item == null)
                {
                    // Destroy item.equipmentPrefab on the Player InventoryItemect
                    IsKnifeHolding = false;
                    Debug.Log("Unequipped Knife on " + tag);
                }
                else
                {
                    // Instantiate item.equipmentPrefab on the Player InventoryItemect
                    IsKnifeHolding = true;
                    Debug.Log("Equipped " + item.myItem.name + " on " + tag);
                }
                break;
        }
    }
*/



}