using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundToggle : MonoBehaviour
{
    private AudioSource audio;

    public void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void musicOnOff()
    {
        if (audio.mute == true)
        {
            print("suka");
            audio.mute = false;
        }
        else
        {
            print("pidor");
            audio.mute = true;
        }
    }
}
