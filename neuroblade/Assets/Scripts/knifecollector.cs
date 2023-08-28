using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifecollector : MonoBehaviour
{
    public savemanager savemanag;  


    private void Awake()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
            GetKnife();
        }
    }

    public void GetKnife()
    {
        savemanag.recepkaan.isKnifeHolding = true;
        savemanag.JsonSave();
    }

}