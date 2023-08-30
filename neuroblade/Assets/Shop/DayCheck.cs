using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DayCheck : MonoBehaviour
{
    public savemanager sv;


    public bool d1checked = false;
    public bool d2checked = false;


    // Update is called once per frame
    void Update()
    {
        if(Day1() && !d1checked)
        {
            sv.recepkaan.d1=true;
            sv.recepkaan.d2=false;
            sv.JsonSave();
            d1checked = true;
            Debug.Log("D1CHECK");
        }
        if(Day2() && !d2checked)
        {
            sv.recepkaan.d1=false;
            sv.recepkaan.d2=true;
            sv.JsonSave();
            d2checked = true;
            Debug.Log("D2 C C C C H H H E E C C K K K");
        }
    }


    private bool Day1()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        return currentScene.name == "InGameCity";
    }

    private bool Day2()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        return currentScene.name == "Day2";
    }


}
