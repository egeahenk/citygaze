using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifecollector : MonoBehaviour
{
    private Inventory inv;
    private escmenu esc;

    [SerializeField] InventoryItem itemPrefab;

    private void Awake()
    {
        inv = FindObjectOfType<Inventory>();
        esc = FindObjectOfType<escmenu>();
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
        esc.OpenEscapeMenu();

    Item[] inventoryItems = inv.GetItems();
    InventorySlot[] inventorySlots = inv.GetInventorySlots();
    
    if (inventoryItems.Length == 0)
    {
        Debug.LogWarning("No items in the 'items' array.");
        return;
    }

    List<Item> knifeItems = new List<Item>();
    foreach (Item item in inventoryItems)
    {
        if (item.itemTag == SlotTag.Knife)
        {
            knifeItems.Add(item);
        }
    }

    if (knifeItems.Count == 0)
    {
        Debug.LogWarning("No items with 'Knife' tag in the 'items' array.");
        return;
    }

    int random = Random.Range(0, knifeItems.Count);
    Item selectedKnifeItem = knifeItems[random];

    for (int i = 0; i < inventorySlots.Length; i++)
    {
        if (inventorySlots[i].myItem == null)
        {
            Instantiate(itemPrefab, inventorySlots[i].transform).Initialize(selectedKnifeItem, inventorySlots[i]);
            break;
        }
    }
}

}