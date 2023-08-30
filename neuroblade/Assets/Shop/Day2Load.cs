using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Day2Load : MonoBehaviour
{

    public savemanager savemanag;
    private bool isLoadedAtFirst = false; 

    // Update is called once per frame
    void Update()
    {
        if(IsPlayerD2() && !isLoadedAtFirst)
        {
            savemanag.JsonLoad();
            isLoadedAtFirst = true;
            Debug.Log("First Load Activated");
            /*
            savemanag.recepkaan.d2=true;
            savemanag.recepkaan.d1=false;
            savemanag.JsonSave();
            savemanag.JsonLoad();
            */
        }
    }


    private bool IsPlayerD2()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        return currentScene.name == "Day2";
    }


}
