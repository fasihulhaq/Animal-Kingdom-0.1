using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NameScore
{
    public string name;
    public int score;

    public NameScore(string num,int sc)
    {
        name = num;
        score = sc;
    }

}
