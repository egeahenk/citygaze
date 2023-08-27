using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ClosedInventorySystem : MonoBehaviour
{


    [SerializeField] private TextMeshProUGUI text;
    public savemanager savemanag;    

    [Header("Knife")]
    public SpriteRenderer spri;
    public Sprite fromnowimg;
    public GameObject knifePanel;

    [Header("Corpse")]
    public SpriteRenderer corp;
    public Sprite corpsefoundimg;
    public GameObject corpsePanel;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
    if (savemanag != null && savemanag.recepkaan != null)
    {
        UpdateCBAmount();
        KnifeImgLoad();
        CorpseFoundLoad();
    }
    else
    {
      Debug.Log("Null SaveManage");
    }
    }

    public void UpdateCBAmount()
    {
        text.text = ": " + savemanag.recepkaan.cardboardamount.ToString();
    }

    void CorpseFoundLoad()
    { if(!savemanag.recepkaan.isCorpseFound) {corp.sprite = fromnowimg;} }
    
    void KnifeImgLoad()
    { if(!savemanag.recepkaan.isKnifeHolding) {spri.sprite = fromnowimg;} }


}
