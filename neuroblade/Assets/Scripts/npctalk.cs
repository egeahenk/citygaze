using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class npctalk : MonoBehaviour
{
    public GameObject diaPanel;
    public TextMeshProUGUI diaText;
    public string[] dialogue;
    private int index;
    
    public float wordSpeed;
    public bool playerCloseCheck; 

    void Start()
    {
        diaText.text = "";
    }

/*    void Update()
    {
        //key etc.
        if(Input.GetKeyDown(KeyCode.E) && playerCloseCheck)
        {
            zeroText();
        }else 
        {
            diaPanel.SetActive(true);
            StartCoroutine(Typing());
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            NextLine();
        }


    }*/
      void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerCloseCheck)
        {
            if (!diaPanel.activeInHierarchy)
            {
                diaPanel.SetActive(true);
                StartCoroutine(Typing());
            }
            else if (diaText.text == dialogue[index])
            {
                NextLine();
            }

        }
        if (Input.GetKeyDown(KeyCode.Q) && diaPanel.activeInHierarchy)
        {
            zeroText();
        }
    }
    public void zeroText()
    {
        diaText.text = "";
        index = 0;
        diaPanel.SetActive(false);
    }

    public void NextLine()
    {
        if(index < dialogue.Length -1)
        {
            index++;
            diaText.text = "";
            StartCoroutine(Typing());
        }else{zeroText();}
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerCloseCheck = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerCloseCheck = false;
            zeroText();
        }
    }

    IEnumerator Typing()
    {
        foreach(char letter in dialogue[index].ToCharArray())
        {
            diaText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }
}
