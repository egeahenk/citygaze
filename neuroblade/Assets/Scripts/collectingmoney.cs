using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectingmoney : MonoBehaviour
{
    public characterstatdata characterstat;
    public savemanager savemanag;
    public musichandler sfx;
    public int amountMoney = 3;
    public GameObject s;

    private void Update()
    {
        if (GameManager.Instance.spLoadOnce && !GameManager.Instance.isCollected)
        {
            s.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !GameManager.Instance.isCollected)
        {
            CollectMoney();
        }
    }

    private void CollectMoney()
    {
        GameManager.Instance.isCollected = true;
        Destroy(gameObject);
        savemanag.recepkaan.currentcash += amountMoney;
        savemanag.JsonSave();
        sfx.CollectSound();
    }
}
