using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class badending : MonoBehaviour
{
    public GameObject panelBad;
    public void GetBadEnding()
    {
        panelBad.SetActive(true);
    }
    public void CloseBadEnding()
    {
        SceneManager.LoadScene(0);
    }
}
