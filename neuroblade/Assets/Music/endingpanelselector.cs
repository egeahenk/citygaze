using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endingpanelselector : MonoBehaviour
{
    public GameObject panelselection;

    public GameObject ge;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            panelselection.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
            panelselection.SetActive(false);
    }


    public void Yes()
    {
        ge.SetActive(true);
    }    


    public void No()
    {
        panelselection.SetActive(false);
    }
}
