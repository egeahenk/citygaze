using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D2BakkalEnter: MonoBehaviour
{

    public savemanager sv;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && IsPlayerInScene3())
        {
            sv.JsonSave();
            SceneManager.LoadScene(2);
        }
    }

    private bool IsPlayerInScene3()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        return currentScene.name == "Day2";
    }


}
