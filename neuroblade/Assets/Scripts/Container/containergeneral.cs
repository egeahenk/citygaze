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
    
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Enter");
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player Detected"); 
            if(Input.GetKey(KeyCode.R) && isCollected)
            {
            Debug.Log("Get Key");
            OpenContainer(); 
            isCollected=true;
            }else return;

        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        Debug.Log("Trigger Exit");
        if(other.CompareTag("Player")) {CloseContainer();}    
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