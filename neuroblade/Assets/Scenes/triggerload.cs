using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerload : MonoBehaviour
{

    public savemanager sv;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            sv.JsonLoad();
        }
    }
}
