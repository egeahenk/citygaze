using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectingmoney : MonoBehaviour
{
    public savemanager savemanag;
    public musichandler sfx;
    public int amountMoney = 3;
    private bool isCollected = false;
    public string objectIdentifier;

    private void Update()
    {
        if(GameManager.Instance.collectedObjects.Contains(objectIdentifier))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !GameManager.Instance.collectedObjects.Contains(objectIdentifier))
        {
            CollectMoney();
        }
    }

    private void CollectMoney()
    {   
        GameManager.Instance.collectedObjects.Add(objectIdentifier);
        Destroy(gameObject);
        isCollected = true; 
        savemanag.recepkaan.currentcash += amountMoney;
        savemanag.JsonSave();
        sfx.CollectSound();
    }
}
