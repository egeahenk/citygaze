using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public GameObject settingsPanel; 
    public GameObject savesPanel;
    public GameObject loaderrorScreen;
    public savemanager savemanage;


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }    

    #region settings
    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    public void CloseSettings() 
    {
        settingsPanel.SetActive(false);
    }

    #endregion

    #region opensavesclosesaves
    public void OpenSaves()
    {
        savesPanel.SetActive(true);
    }

    public void CloseSaves() 
    {
        savesPanel.SetActive(false);
    }

    public void loaderrorScreenFalse() 
    {
        loaderrorScreen.SetActive(false);
    }

    public void loaderrorScreenTrue()
    {
    loaderrorScreen.SetActive(true);
    }
    #endregion

    public void ExitGame()
    {
        Debug.Log("game closed");
        Application.Quit();
    }

}
