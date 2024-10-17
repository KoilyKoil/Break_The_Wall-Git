using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class Advertisement : MonoBehaviour
{
    private string rewardID = "ca-app-pub-2398042213816518/9622457855";

    private string rewardTestID = "ca-app-pub-3940256099942544~3347511713";

    private RewardedAd rewardedAd;

    private bool rewarded = false;

    public GameObject GameOverPanel, Player, ContinueButton;

    void Start()
    {
        rewardedAd = new RewardedAd(rewardID);
        AdRequest request = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(request);     //광고 로드

        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;        //유저가 광고를 끝까지 봤을때
        rewardedAd.OnAdClosed += HandleRewardedAdClosed;
    }

    public float SetX = -91f;
    public float SetY = 1044f;

    void Update()
    {
        if (rewarded)               //리워드를 얻을 수 있게 되면
        {
            //보상들
            DataManager.PlayerDie = false;
            ContinueButton.SetActive(false);
            GameOverPanel.SetActive(false);
            Player.transform.position = new Vector3(SetX, SetY, 0f);
            //Player.transform.Translate(-91f, 1044f, 0f);
            Time.timeScale = 1;
            rewarded = false;
        }
    }

    public void UserChoseToWatchAd()
    {
        if (rewardedAd.IsLoaded())          //광고가 준비되면
        {
            rewardedAd.Show();          //광고 보여주기
        }
    }

    public void CreateAndLoadRewardedAd()       //광고 다시 로드
    {
        rewardedAd = new RewardedAd(rewardID);

        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;        //유저가 광고를 끝까지 봤을때
        rewardedAd.OnAdClosed += HandleRewardedAdClosed;            //유저가 광고를 끝까지 못봤을때

        AdRequest request = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(request);
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)       //사용자가 광고를 닫았을 때
    {
        CreateAndLoadRewardedAd();              //광고 다시 로드
    }

    private void HandleUserEarnedReward(object sender, Reward e)            //광고를 다 봤을 때
    {
        rewarded = true;
    }
}
