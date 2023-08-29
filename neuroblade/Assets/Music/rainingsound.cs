using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainingsound : MonoBehaviour
{
    public musichandler sfx; 

    // Update is called once per frame
    void Update()
    {
            sfx.RainingSound();
    }
}
