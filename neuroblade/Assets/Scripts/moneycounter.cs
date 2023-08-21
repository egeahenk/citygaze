using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class moneycounter : MonoBehaviour
{
    private TextMeshProUGUI text;
    public savemanager savemanag;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        text.text = savemanag.recepkaan.currentcash.ToString() + "$";
    }
}


/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class moneycounter : MonoBehaviour
{
    private TextMeshProUGUI text;
    public characterstatdata characterstat;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        text.text = characterstat.currentcash + "$";
    }
}


*/