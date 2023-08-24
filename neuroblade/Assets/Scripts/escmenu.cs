using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using TMPro;

public class escmenu : MonoBehaviour
{

    public GameObject escapePanel;
    public TextMeshProUGUI orangeCash;
    

    #region escmenu
    
    public void OpenEscapeMenu()
    {
        escapePanel.SetActive(true);
        orangeCash.gameObject.SetActive(false);
        isESCopen = true;
    }

    public void CloseEscapeMenu()
    {
        escapePanel.SetActive(false);
        orangeCash.gameObject.SetActive(true);
        isESCopen = false;
    }

    #endregion
    
    bool isESCopen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isESCopen) { CloseEscapeMenu(); } else { OpenEscapeMenu(); }
        }
    }
}
