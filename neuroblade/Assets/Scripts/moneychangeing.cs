using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class moneychangeing : MonoBehaviour
{
    public characterstatdata characterstat;

    public savemanager savemanag;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        { 
            savemanag.recepkaan.currentcash += 100;
            savemanag.JsonSave();
        }
        else if(Input.GetKeyDown(KeyCode.Y))
        {
            savemanag.recepkaan.currentcash -= 100;
            savemanag.JsonSave();
        }
    }

}


/*using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class moneychangeing : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        { 
        savemanager.instance.money += 100;
        savemanager.instance.Save();
        }
        else if(Input.GetKeyDown(KeyCode.Y))
        {
        savemanager.instance.money -= 100;
        savemanager.instance.Save();
        }
    }

}
*/