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
}