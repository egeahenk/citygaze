using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D2BakkalEnterence : MonoBehaviour
{

    public savemanager sv;
    DayHandler dh;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && IsPlayerInScene3())
        {
            EnterBakkal();
        }
    }
    public void EnterBakkal()
    {
        sv.JsonSave();
        SceneManager.LoadScene(2);
        dh.isFromD2 = true;
        dh.isFromD1 = false;
    }    

    private bool IsPlayerInScene3()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        return currentScene.name == "Day2";
    }


}
