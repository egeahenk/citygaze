using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class characterstatdata
{
    public string realname;
    public int currentcash;
    public int mind;
    public int body;


    public characterstatdata()
    {

    }
    public characterstatdata(string realname, int currentcash, int mind, int body)
    {
        this.realname = realname;
        this.currentcash = currentcash;
        this.mind = mind;
        this.body = body;
    }
}
