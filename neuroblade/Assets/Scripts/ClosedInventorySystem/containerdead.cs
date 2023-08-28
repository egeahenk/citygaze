using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEditor;

public class containerdead : MonoBehaviour
{
    public SpriteRenderer spri;
    public Sprite closedContainer;
    public Sprite openContainer;

    public ClosedInventorySystem closeinv;
    public bool isCollected = false;
    public bool isTriggered = false;
    public savemanager savemanag;  

    private void Awake()
    {
        
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.E) && !isCollected && isTriggered)
        {
            OpenContainer();
            isCollected = true;
            GetCorpse();
        }else return;
    }

    public void GetCorpse()
    {
        savemanag.recepkaan.isCorpseFound = true;
        savemanag.JsonSave();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {if (other.CompareTag("Player")) {isTriggered = true;}}


    private void OnTriggerExit2D(Collider2D other) 
    {if(other.CompareTag("Player")) {CloseContainer(); isTriggered = false;}}

    void OpenContainer()
    {
        spri.sprite = openContainer;
    }

    void CloseContainer()
    {
        spri.sprite = closedContainer;
    }

}