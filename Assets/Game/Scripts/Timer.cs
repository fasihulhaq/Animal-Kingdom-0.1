using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    public GameObject panel1;
    public GameObject panel3;
    public GameObject check;
    public static int countDownStartValue = 60;
    private float stopTime;
    public Text timerUI;
    void Start()
    {
        countDownTimer();
    }

    public void countDownTimer()
    {
        if(countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text = "Timer : " + spanTime.Minutes + " : " + spanTime.Seconds;
            if (check.active==true)
            {
                countDownStartValue--;
            }
            Invoke("countDownTimer",1.0f);
        }
        else
        {
            timerUI.text = "";
            panel3.SetActive(true);
            panel1.SetActive(false);
        }
    }
}
