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


    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape) && end)
        {
            SceneManager.LoadScene(0);
        }
    }


    public bool end = false;
    public void Yes()
    {
        ge.SetActive(true);
        end = true;
    }    


    public void No()
    {
        panelselection.SetActive(false);
    }
}
