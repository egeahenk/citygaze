using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class useknife : MonoBehaviour
{

    public savemanager save;
    public GameObject pressKey;
    public GameObject noKnife;

    public GameObject be;
    private bool interactable = false;


    private void Update()
    {
        if (interactable && Input.GetKeyDown(KeyCode.E))
        {   
            Debug.Log("useknifeused");
            Debug.Log("Pressed E");
            be.SetActive(true);
            pressKey.SetActive(false);
            noKnife.SetActive(false);
            beopen=true;
        }   
        if(beopen && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(0);
        }
    }

    public bool beopen =false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && save.recepkaan.isKnifeHolding)
        {
        pressKey.SetActive(true);
        interactable = true;
        }else if (other.CompareTag("Player") && !save.recepkaan.isKnifeHolding)
        {
            noKnife.SetActive(true);
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            pressKey.SetActive(false);
            noKnife.SetActive(false);
            interactable = false;
        }
    }


}
