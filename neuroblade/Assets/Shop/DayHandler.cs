using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DayHandler : MonoBehaviour
{
    public bool isFromD1 = false;
    public bool isFromD2 = false;

    ShopScript ss;

    private void Update()
    {
        if(isFromD2=true){ss.isBuyable = true;}
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !isFromD1)
        { isFromD1 = false;  GoD1();}
        if(other.CompareTag("Player") && !isFromD2)
        { isFromD2 = false; GoD2();}
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
