using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class savemanager : MonoBehaviour
{

    public characterstatdata recepkaan = new characterstatdata("recepkaan", 5, 1, false, false, false, false, false);


    private void Update()
    {
        if(Input.GetKey(KeyCode.O))
        {
            JsonSave();
        }

        if(Input.GetKey(KeyCode.P))
        {
            JsonLoad();
        }
    }


    public void JsonSave()
    {
        string playersData = JsonUtility.ToJson(recepkaan);
        string filePath = Application.persistentDataPath+"/Saves/playerdata.json";
        Debug.Log(filePath);
        File.WriteAllText(filePath, playersData);
        Debug.Log("JsonSave ACTIVATED");
    }

    public void JsonLoad()
    {
        string filePath = Application.persistentDataPath+"/Saves/playerdata.json";
        string playersData = File.ReadAllText(filePath);

        recepkaan = JsonUtility.FromJson<characterstatdata>(playersData); 
        Debug.Log("jsonload activated"); 
    }   

}