using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerScript : MonoBehaviour
{
    public GameObject show;
    //public Text playerName;
    void Start()
    {
        show.SetActive(true);

        //LeaderBoard.instance.GetPlayerName(playerName);
    }
}
