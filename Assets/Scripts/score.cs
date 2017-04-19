using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class score : MonoBehaviour {

    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Text highscoreText;
    public int scorecounter;

    void Start()
    {
	//	scoreText = GetComponent<Text> ();
        scorecounter = 0;
        displayScore();
    }


    public  void addScore()
    {
        print("adding score");
        scorecounter = scorecounter + 10;
        displayScore();
        // change the text in the UI script Text
    }
    public  void displayScore()
    {
		scoreText.text = "Score: "+scorecounter.ToString();
    }

    public void displayHighScore()
    {
            highscoreText.text = highscoreText.ToString();
    }

    public void storeHighscore(int newHighscore)
    {
        int oldHighscore = PlayerPrefs.GetInt("highscore", 0);
        if (newHighscore > oldHighscore)
            PlayerPrefs.SetInt("highscore", newHighscore);
        PlayerPrefs.Save();
    }
}
