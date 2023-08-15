using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public GameObject settingsPanel; 

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }    

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    public void CloseSettings() 
    {
        settingsPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Debug.Log("game closed");
        Application.Quit();
    }
}
