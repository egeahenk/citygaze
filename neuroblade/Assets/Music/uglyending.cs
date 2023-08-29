using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uglyending : MonoBehaviour
{
    public GameObject panelugly;

    public void GetUglyEnding()
    {
        panelugly.SetActive(true);
    }

    public void CloseUglyEnding()
    {
        SceneManager.LoadScene(0);
    }
}