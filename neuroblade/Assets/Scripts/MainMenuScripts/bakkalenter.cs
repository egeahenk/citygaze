using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bakkalenter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && IsPlayerInScene1())
        {
            EnterBakkal();
        }

        if(other.CompareTag("Player") && IsPlayerInScene2())
        {
            ExitBakkal();
        }
    }

    public void EnterBakkal()
    {
        SceneManager.LoadScene(2);
    }    

    public void ExitBakkal()
    {
        SceneManager.LoadScene(1);
    }

    private bool IsPlayerInScene1()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        return currentScene.name == "InGameCity";
    }

    private bool IsPlayerInScene2()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        return currentScene.name == "Bakkal";
    }


}
