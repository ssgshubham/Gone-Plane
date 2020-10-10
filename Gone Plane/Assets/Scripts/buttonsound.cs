using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class buttonsound : MonoBehaviour
{
    public AudioSource Myfx;
    public AudioClip clickfx;

    public void ClickSound()
    {
        Myfx.PlayOneShot(clickfx);
    }
}
