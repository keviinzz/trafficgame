using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundToggle : MonoBehaviour
{
    private AudioSource audio;
    private AudioSource clickSound;

    public void Start()
    {
        clickSound = GetComponent<AudioSource>();
        audio = GetComponent<AudioSource>();
    }
    public void musicOnOff()
    {
        if (audio.mute == true)
        {
            print("suka");
            clickSound.Play();
            audio.mute = false;
        }
        else
        {
            print("pidor");
            clickSound.Play();
            audio.mute = true;
        }
    }
}
