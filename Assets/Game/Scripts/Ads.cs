using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class Ads : MonoBehaviour, IUnityAdsListener
{
    private int rewardedScore;
    private int looseRewarded;
    public Text showRewardedScore;
    public Text showRewardedLooseScore;
    private int rewardIndex;
    void Start()
    {
        Advertisement.Initialize("4393361");
        Advertisement.AddListener(this);
    }

    public void RewardedAd(int reward)
    {
        rewardIndex = reward;
        if (Advertisement.IsReady("Rewarded_Android"))
        {
            Advertisement.Show("Rewarded_Android");
        }
        else
        {
            Debug.Log("Ad is not Ready");
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
        Debug.Log("ADDs are ready !");
    }

    public void OnUnityAdsDidError(string message)
    {
        Debug.Log("Error !");
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        Debug.Log("Video did Start !");
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (placementId == "Rewarded_Android" && showResult == ShowResult.Finished)
        {
            if (rewardIndex == 0)
            {
                rewardedScore = PlayerControlerAnimator.finalScore;
                showRewardedScore.text = rewardedScore.ToString();
                Debug.Log(rewardedScore);
            }
            if(rewardIndex == 1)
            {
                Timer.countDownStartValue += 20;
                Timer.instance.countDownTimer();
                Debug.Log("Ad Active");
            }
        }
    }
}
