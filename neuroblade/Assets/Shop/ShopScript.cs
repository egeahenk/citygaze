using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class ShopScript : MonoBehaviour
{
    public savemanager savemanag;  

    public TextMeshProUGUI pricetext;

    public int newsprice = 500;

    [Header("GameObject")]
    public GameObject AlienTechSp;
    public GameObject NewsPaperSp;

    public GameObject NewsPaper;

    public GameObject panelBuy;

    [Header("Bool")]
    public bool isBuyable = false;

    public bool buyable = false;

    public bool isNewsPaperOpened = false;



    public void Exit()
    {
        panelBuy.SetActive(false);
    }

    public void AlienTech()
    {
        if(savemanag.recepkaan.currentcash >= 70)
        {
            savemanag.recepkaan.currentcash -= 70;
            savemanag.recepkaan.isAlienTech = true;
            Destroy(AlienTechSp);
            savemanag.JsonSave();
        }
    }

    public void NewsPaperBuy()
    {
        if(savemanag.recepkaan.currentcash >= newsprice && isBuyable)
        {
            panelBuy.SetActive(false);
            Destroy(NewsPaperSp);
            savemanag.recepkaan.currentcash -= newsprice;
            NewsPaper.SetActive(true);
            isNewsPaperOpened = true;
            savemanag.JsonSave();
        }
    }

    public void CardBoardSell()
    {
        if(savemanag.recepkaan.cardboardamount >= 1)
        {
            savemanag.recepkaan.cardboardamount --;
            savemanag.recepkaan.currentcash ++;
            savemanag.JsonSave();
        }else if(savemanag.recepkaan.cardboardamount == 0)
        {
            return;
        }
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {buyable = true;}
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {buyable=false;}
    }

    public void Update()
    {
        if(isNewsPaperOpened && Input.GetKey(KeyCode.E))
        {
            isNewsPaperOpened = false;
            NewsPaper.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.E) && buyable)
        {
            panelBuy.SetActive(true);
        }

        if(isBuyable)
        {
            newsprice = 35;
            pricetext.text = newsprice + "$";
        }
    }


}
