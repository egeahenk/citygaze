using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public GameObject settingsPanel; 
    public GameObject savesPanel;
    public savemanager savemanage;
	

	private void Awake()
	{
         savemanage.recepkaan.currentcash = 5;
         savemanage.recepkaan.isKnifeHolding = false;
         savemanage.recepkaan.isCorpseFound = false;
         savemanage.recepkaan.isAlienTech = false;
         savemanage.recepkaan.d1 = true;
         savemanage.recepkaan.d2 = false;
         savemanage.recepkaan.cardboardamount = 1;
         savemanage.JsonSave();
	}

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

    public void ExitGame()
    {
        Debug.Log("game closed");
        Application.Quit();
    }

}
