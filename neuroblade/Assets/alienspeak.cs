using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class alienspeak : MonoBehaviour
{
    public GameObject ugly;

    public savemanager sv;
    public bool inUgly;                                                                                                                                                                         
    public bool trigered;

    void Update()
    {
        if(Input.GetKey(KeyCode.E) && sv.recepkaan.isAlienTech && trigered)
        {
            ugly.SetActive(true);
            inUgly = true;
        }
        if(Input.GetKey(KeyCode.Escape) && inUgly)
        {
            SceneManager.LoadScene(0);                                                                             
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            trigered = true;
        }
    } 

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            trigered = false;
        }
    } 



}
