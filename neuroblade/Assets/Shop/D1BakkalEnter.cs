using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D1BakkalEnter : MonoBehaviour
{
    public savemanager sv;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && sv.recepkaan.d1)
        {
            sv.JsonSave();
            SceneManager.LoadScene(2);
        }
    } 


    private bool IsPlayerInScene1()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        return currentScene.name == "InGameCity";
    }
}
