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
    public void ExitOn()
    {
        Application.Quit();
    }
    public void LoadOn()
    {
        System.Threading.Thread.Sleep(150);
        Application.LoadLevel ("game");
    }
}
