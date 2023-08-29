using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class goodending : MonoBehaviour
{
    public GameObject panelGood;

    public void GetGoodEnding()
    {
        panelGood.SetActive(true);
    }

    public void CloseGoodEnding()
    {
        SceneManager.LoadScene(0);
    }
}