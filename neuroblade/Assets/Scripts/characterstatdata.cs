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

    public bool isAlienTech;


    public bool d1;
    public bool d2;


    public characterstatdata()
    {

    }
    public characterstatdata(string realname, int currentcash, int cardboardamount, bool isKnifeHolding, bool isCorpseFound, bool isAlienTech, bool d1, bool d2)
    {
        this.realname = realname;
        this.currentcash = currentcash;
        this.cardboardamount = cardboardamount;
        this.isKnifeHolding = isKnifeHolding;
        this.isCorpseFound = isCorpseFound;
        this.isAlienTech = isAlienTech;
        this.d1 = d1;
        this.d2 = d2;
    }
}
