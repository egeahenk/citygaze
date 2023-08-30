using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bakkalenter : MonoBehaviour
{

    public DayHandler dh;
    
    public savemanager sv;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && IsPlayerInScene1())
        {
            EnterBakkal();
        }
    }

    public void EnterBakkal()
    {
        sv.JsonSave();
        dh.isFromD1 = true;
        dh.isFromD2 = false;
        SceneManager.LoadScene(2);
    }    


    private bool IsPlayerInScene1()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        return currentScene.name == "InGameCity";
    }
}
