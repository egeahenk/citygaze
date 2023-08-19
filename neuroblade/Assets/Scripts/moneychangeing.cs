using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class moneychangeing : MonoBehaviour
{
    public characterstatdata characterstat;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        { 
            characterstat.currentcash += 100;
        }
        else if(Input.GetKeyDown(KeyCode.Y))
        {
            characterstat.currentcash -= 100;
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