using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoard : MonoBehaviour
{
    public static LeaderBoard instance;
    //public Text playerName;
    public GameObject prefab;
    public Transform prefabParent;
    //public Text fnameText;
    //public string fname = GameConstants.fPlayerName;
    private string showLeaderBoard;
    private int showLeaderBoardScore;
    [SerializeField]List<NameScore> namescore = new List<NameScore>();
    int totalScoreValues;

    private void Awake()
    {
        if (instance!=null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        //DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        //StartCoroutine(LeaderBoardShow());
        totalScoreValues = PlayerPrefs.GetInt("totalScoreValues", 0);
        //fnameText.text = fname;
        LeaderBoardLoad();
    }
    
    public void LeaderBoardLoad()
    {
        //Debug.Log("total Score values: " + totalScoreValues);
        for (int i = 0; i < totalScoreValues; i++)
        {
            if(PlayerPrefs.HasKey("PlayerName" + i))
            showLeaderBoard = PlayerPrefs.GetString("PlayerName" + i);

            if (PlayerPrefs.HasKey("PlayerScore" + i))
                showLeaderBoardScore = PlayerPrefs.GetInt("PlayerScore" + i);

            namescore.Add(new NameScore(showLeaderBoard, showLeaderBoardScore));
            GameObject go = Instantiate(prefab, prefabParent);
            GameObject childGameObject1 = go.transform.GetChild(0).gameObject;
            GameObject childGameObject2 = go.transform.GetChild(1).gameObject;
            Text playerName = childGameObject1.GetComponent<Text>();
            Text playerScore = childGameObject2.GetComponent<Text>();
            playerName.text = showLeaderBoard;
            playerScore.text = showLeaderBoardScore.ToString();
            Debug.Log(showLeaderBoard + showLeaderBoardScore);
    
        }
    }

    public void LeaderBoardShow()
    {
        //yield return new WaitForSeconds(60.0f);
        namescore.Add(new NameScore(GameConstants.fPlayerName, Score.score));

        for (int i = 0; i < namescore.Count; i++)
        {
            NameScore n = namescore[i];
            //playerName.text = n.name + n.score.ToString();
            PlayerPrefs.SetString("PlayerName" + i, n.name);
            PlayerPrefs.SetInt("PlayerScore" + i, n.score);
            PlayerPrefs.SetInt("totalScoreValues", i + 1);

            Debug.Log(n.name + "::::" + n.score);
        }
    }

    /*public void GetPlayerName(Text t)
    {
        playerName = t;
    }*/
}
