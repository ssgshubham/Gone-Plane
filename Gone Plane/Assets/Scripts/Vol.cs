using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Vol : MonoBehaviour
{
    public AudioMixer audiomixer;

    public void setvolume(float Volume)
    {
        audiomixer.SetFloat("Volume", Volume);
    }
}
