using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEditor;

public class containergeneral : MonoBehaviour
{
    private Inventory inv;

    public SpriteRenderer spri;
    public Sprite closedContainer;
    public Sprite openContainer;


    public bool isCollected = false;
    public bool isTriggered = false;

    void Start()
    {
        inv = FindObjectOfType<Inventory>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.R) && !isCollected && isTriggered)
        {
            Debug.Log("R Key");
            OpenContainer();
            isCollected = true;
            inv.GetCardboard();
        }else return;
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