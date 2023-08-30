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


    void Update()
    {
        if(Input.GetKey(KeyCode.E) && sv.recepkaan.isAlienTech && trigered)
        {
            ugly.SetActive(true);
            inUgly = true;
        }
        if(Input.GetKey(KeyCode.E) && inUgly)
        {
            SceneManager.LoadScene(0);                                                                             
        }
    }
    public bool trigered;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && sv.recepkaan.d1)
        {
            trigered = true;
        }
    } 





}
