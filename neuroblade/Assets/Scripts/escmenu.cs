using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escmenu : MonoBehaviour
{

    public GameObject escapePanel;

    #region escmenu
    
    public void OpenEscapeMenu()
    {
        escapePanel.SetActive(true);
    }

    public void CloseEscapeMenu()
    {
        escapePanel.SetActive(false);
    }

    #endregion
    void Update()
    {

        
        if(Input.GetKey(KeyCode.Escape))
        {
            OpenEscapeMenu();
        }


    }
}
