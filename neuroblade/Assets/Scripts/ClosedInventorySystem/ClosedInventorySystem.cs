using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class ClosedInventorySystem : MonoBehaviour
{

    public GameObject Texty;
    [SerializeField]private TextMeshProUGUI text;
    public savemanager savemanag;
 

    [Header("Knife")]
    public GameObject knifePanel;
    public GameObject Knife;

    [Header("Corpse")]
    public GameObject corpsePanel;
    public GameObject Corpse;

    private void Awake()
    {
        text = Texty.GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {

            UpdateCBAmount();

            KnifeImgLoad();
            CorpseFoundLoad();

    }

    public void UpdateCBAmount()
    {
        text.text = ": " + savemanag.recepkaan.cardboardamount.ToString();
    }

    void CorpseFoundLoad()
    { if(savemanag.recepkaan.isCorpseFound) {Corpse.SetActive(true);} }
    
    void KnifeImgLoad()
    { if(savemanag.recepkaan.isKnifeHolding) {Knife.SetActive(true);} }


}
