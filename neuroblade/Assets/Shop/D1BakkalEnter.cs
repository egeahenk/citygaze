using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D1BakkalEnter : MonoBehaviour
{
    public savemanager sv;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && sv.recepkaan.d1)
        {
            Debug.Log("-----------------BakkalTrigger----------------");
            sv.JsonSave();
            SceneManager.LoadScene(2);
        }
    }
}
