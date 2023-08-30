using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class isBakkalEntered : MonoBehaviour
{

    public savemanager savemanag;

    private bool isLoadedAtFirst = false; 

    // Update is called once per frame
    void Update()
    {
        if(IsPlayerInBakkal() && !isLoadedAtFirst)
        {
            savemanag.JsonLoad();
            isLoadedAtFirst = true;
            Debug.Log("First Load Activated");
        }
    }



    private bool IsPlayerInBakkal()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        return currentScene.name == "Bakkal";
    }

}
