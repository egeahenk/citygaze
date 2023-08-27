using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryItem : MonoBehaviour
{
    Image itemIcon;
    public CanvasGroup canvasGroup {get; private set;}

    public Item myItem {get; set;}
    public InventorySlot activeSlot {get; set;}
/*
    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        itemIcon = GetComponent<Image>();
    }

    public void Initialize(Item item, InventorySlot parent)
    {
        activeSlot = parent;
        activeSlot.myItem = this;
        myItem = item;
        itemIcon.sprite = item.sprite;
    }


    public event Action<InventoryItem> OnItemClicked,
            OnItemDropped, OnItemBeginDragged, OnItemEndDrag,
            OnRightMouseBtnClick;

    private bool empty = true;

    public void SetData(Sprite sprite)
    {
        this.itemIcon.sprite = sprite;
        this.empty = false;
    }
    public void OnBeingDrag()
    {

        OnItemBeginDragged?.Invoke(this);
    }
    public void OnDrop()
    {
        OnItemDropped?.Invoke(this);
    }
    public void OnEndDrag()
    {
        OnItemEndDrag?.Invoke(this);
    }

    public void OnPointerClick(BaseEventData data)
    {
    if(empty) return;

        PointerEventData pointerData = (PointerEventData)data;
        if(pointerData.button == PointerEventData.InputButton.Right)
        {

        }else {OnItemClicked?.Invoke(this);}
    }*/

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        itemIcon = GetComponent<Image>();
    }

    public void Initialize(Item item, InventorySlot parent)
    {
        activeSlot = parent;
        activeSlot.myItem = this;
        myItem = item;
        itemIcon.sprite = item.sprite;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            Inventory.Singleton.SetCarriedItem(this);
        }
    }
    
}
