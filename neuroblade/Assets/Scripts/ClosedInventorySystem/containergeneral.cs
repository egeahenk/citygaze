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

    public ClosedInventorySystem closeinv;
    public bool isCollected = false;
    public bool isTriggered = false;
    public savemanager savemanag;  

    public musichandler sfx; 

    private void Awake()
    {
        
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.E) && !isCollected && isTriggered)
        {
            OpenContainer();
            isCollected = true;
            GetCardboard();
        }else return;
    }

    public void GetCardboard()
    {
        savemanag.recepkaan.cardboardamount += 1;
        savemanag.JsonSave();
        sfx.CollectSound();
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
        spri.sprite = openContainer;
    }

    void CloseContainer()
    {
        spri.sprite = closedContainer;
    }

}