using System;
using System.IO;
using UnityEngine;

public class savemanager : MonoBehaviour
{
    public characterstatdata recepkaan = new characterstatdata("recepkaan", 5, 1, false, false, false, false, false, false);

    private void Update()
    {
        if (Input.GetKey(KeyCode.F5))
        {
            JsonSave();
        }

        if (Input.GetKey(KeyCode.F8))
        {
            JsonLoad();
        }
    }

    public void JsonSave()
    {
        string playersData = JsonUtility.ToJson(recepkaan);
        string savePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Neuroblade",
            "Citygaze",
            "Saves",
            "playerdata.json"
        );

        Debug.Log(savePath);
        Directory.CreateDirectory(Path.GetDirectoryName(savePath));

        File.WriteAllText(savePath, playersData);
    }

    public void JsonLoad()
    {
        string loadPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Neuroblade",
            "Citygaze",
            "Saves",
            "playerdata.json"
        );

        string playersData = File.ReadAllText(loadPath);
        recepkaan = JsonUtility.FromJson<characterstatdata>(playersData);
    }
}
