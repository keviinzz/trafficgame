using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Canvas MainCanvas;
    //public Canvas OptionsCanvas;

    private void Awake()
    {
    //    OptionsCanvas.enabled = false;
    }
    public void OptionsOn()
    {
    //    OptionsCanvas.enabled = true;
        MainCanvas.enabled = false;
    }
    public void ReturnOn()
    {
    //    OptionsCanvas.enabled = false;
        MainCanvas.enabled = true;
    }
    public void ExitOn()
    {
        Application.Quit();
    }
    public void LoadOn()
    {
        Application.LoadLevel ("game");
    }
}
