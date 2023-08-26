using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public enum SlotTag { None, Eatable, Knife, cardboard }

[CreateAssetMenu(menuName = "ScriptableObjects/Item")]
public class Item : ScriptableObject
{
    public Sprite sprite;
    public SlotTag itemTag;

    [Header("If the item can be equipped")]
    public GameObject equipmentPrefab;

    public event Action<Item> OnItemClicked,
            OnItemDropped, OnItemBeginDragged, OnItemEndDrag,
            OnRightMouseBtnClick;

    private bool empty = true;

    public void SetData(Sprite sprite)
    {
        this.sprite = sprite;
        this.empty = false;
    }

    public void Select()
    {
        
    }

    public void OnBeingDrag()
    {
        if(empty) return;
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
        PointerEventData pointerData = (PointerEventData)data;
        if(pointerData.button == PointerEventData.InputButton.Right)
        {

        }else {OnItemClicked?.Invoke(this);}
    }


}