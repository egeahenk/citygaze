using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class characterstatdata
{
    public string realname;
    public int currentcash;
    public bool isKnifeHolding;
    public int cardboardamount;
    public bool isCorpseFound;


    public characterstatdata()
    {

    }
    public characterstatdata(string realname, int currentcash, int cardboardamount, bool isKnifeHolding, bool isCorpseFound)
    {
        this.realname = realname;
        this.currentcash = currentcash;
        this.cardboardamount = cardboardamount;
        this.isKnifeHolding = isKnifeHolding;
        this.isCorpseFound = isCorpseFound;
    }
}
