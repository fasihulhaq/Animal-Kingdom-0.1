using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighGameScore : MonoBehaviour
{
    public Text score;
    public Text HighScore;
    void Start()
    {
        StartCoroutine(UpdateScore());
    }

    IEnumerator UpdateScore()
    {
        yield return new WaitForSeconds(60.0f);
        score.text = Score.score.ToString();
        HighScore.text = Score.highscore.ToString();
    }

}
