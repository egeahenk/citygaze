using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifecollector : MonoBehaviour
{
    private Inventory inv;
    private escmenu esc;
    private void Start()
    {
        inv = FindObjectOfType<Inventory>();
        esc = FindObjectOfType<escmenu>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
            if (inv != null) {inv.GetKnife();}
        }
    }
}
