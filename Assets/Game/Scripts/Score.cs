using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instace;
    public static int score, highscore;
    public Text scoreView;
    public Text highScoreView;
    private void Awake()
    {
        if(instace != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instace = this;

            if (PlayerPrefs.HasKey("HighScore"))
            {
                highscore = PlayerPrefs.GetInt("HighScore");
                highScoreView.text = highscore.ToString();

            }
        }
    }
    public void AddScore()
    {
        score += 20;
        HighScore();
        scoreView.text = score.ToString();
    }

    public void HighScore()
    {
        if(score > highscore)
        {
            highscore = score;
            highScoreView.text = highscore.ToString();
            PlayerPrefs.SetInt("HighScore",highscore);
        }
    }
}
