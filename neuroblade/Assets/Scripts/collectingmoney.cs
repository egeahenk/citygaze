using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectingmoney : MonoBehaviour
{
    public characterstatdata characterstat;
    public savemanager savemanag;  

    public int amountMoney = 3; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            CollectMoney();
        }
    }

    private void CollectMoney()
    {
        Destroy(gameObject);
        savemanag.recepkaan.currentcash += amountMoney;
        savemanag.JsonSave();
    }
}
