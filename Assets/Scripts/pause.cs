using System.Linq;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class pause : MonoBehaviour
{
    public xuj xujo;
    bool paused = false;
    public GameObject intro;

    private void Start()
    {
        paused = togglePause();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            paused = togglePause();
    }
    public void buttonPause()
    {
        paused = togglePause();
    }
    bool togglePause()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            xujo.gameObject.SetActive(false);
            return (false);
        }
        else
        {
            Time.timeScale = 0;
            xujo.gameObject.SetActive(true);
            return (true);
        }
    }

    public void buttonIntro()
    {
        paused = togglePause();
        intro.SetActive(false);
    }
}