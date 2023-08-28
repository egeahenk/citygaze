using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class escmenu : MonoBehaviour
{

    public savemanager save;

    public GameObject escapePanel;

    public GameObject settingPanel;

    
    #region escmenu
    
    public void OpenEscapeMenu()
    {
        escapePanel.SetActive(true);
        isESCopen = true;
    }

    public void CloseEscapeMenu()
    {
        escapePanel.SetActive(false);
        isESCopen = false;
    }

    #endregion

    #region settings
    public void Settings()
    {
        settingPanel.SetActive(true);
    }
    public void QuitSettings()
    {
        settingPanel.SetActive(false);
    }
    #endregion  

    public void MainMenu()
    {
        save.JsonSave();
        SceneManager.LoadScene(0);
    }

    public void ExitAndSave()
    {
        save.JsonSave();
        Application.Quit();
        Debug.Log("Application Quit");
    }


    
    bool isESCopen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isESCopen) { CloseEscapeMenu(); } else { OpenEscapeMenu(); }
        }
    }
}
