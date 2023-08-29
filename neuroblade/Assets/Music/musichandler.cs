using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musichandler : MonoBehaviour
{

    public AudioSource src;
    public AudioClip sfx, background;


    public void CollectSound()
    {
        src.clip = sfx;
        src.Play();
    }

    public void RainingSound()
    {
        src.clip = background;
        src.Play();
    }

}
