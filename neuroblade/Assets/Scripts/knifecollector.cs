using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifecollector : MonoBehaviour
{
    private Inventory inv;
    private void Awake()
    {
        inv = FindObjectOfType<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
            inv.GetKnife();
        }
    }
}
