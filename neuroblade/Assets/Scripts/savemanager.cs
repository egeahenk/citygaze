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
    public MenuHandler menuhand;
    public characterstatdata recepkaan = new characterstatdata("recepkaan", 20, 3, 5);

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
/*
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class savemanager : MonoBehaviour
{
    public static savemanager instance {get; private set;}

    public int money;

    private void Awake()
    {
        if(instance != null && instance != this)
        Destroy(gameObject);
        else
        instance = this;

        DontDestroyOnLoad(gameObject);
        Load();
    }
    
    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData_Storage data = (PlayerData_Storage)bf.Deserialize(file);

            money = data.money;

            file.Close();
        }
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        PlayerData_Storage data = new PlayerData_Storage();
        //datas
        data.money = money;

        bf.Serialize(file, data);
        file.Close();
    }

}


[Serializable]
class PlayerData_Storage
{
    public int money;
}
*/