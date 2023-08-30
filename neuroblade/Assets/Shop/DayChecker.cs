using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayChecker : MonoBehaviour
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
        }
    }



    private bool IsPlayerD2()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        return currentScene.name == "Day2";
    }
}
