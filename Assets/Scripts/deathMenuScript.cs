using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathMenuScript : MonoBehaviour
{
    public Canvas DeathCanvas;
    public deathMenuScript deathMenu;
    public score sc;

    public void ExitOn()
    {
        Application.Quit();
    }
    public void LoadOn()
    {
        System.Threading.Thread.Sleep(150);
        Time.timeScale = 1;
        Application.LoadLevel("game");
    }


}
