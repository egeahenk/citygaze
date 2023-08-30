using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BakkalDoor : MonoBehaviour
{
    public ShopScript ss;
    public savemanager sv;
    
    private void Awake()
    {
        ss = FindObjectOfType<ShopScript>();
    }

    public bool isCheck = false;

    private void Update()
    { 
        if (sv.recepkaan.d2 && ss != null){ss.isBuyable = true;}
        if(!isCheck)
        {
            sv.JsonLoad();
            isCheck=true;
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && sv.recepkaan.d1)
        { GoD1(); }
        if(other.CompareTag("Player") && sv.recepkaan.d2)
        { GoD2(); }
    }

    public void GoD1()
    {
        SceneManager.LoadScene(1);
    }    

    public void GoD2()
    {
        SceneManager.LoadScene(3);
    }    

}
