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
        rewardedAd.LoadAd(request);     //���� �ε�

        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;        //������ ���� ������ ������
        rewardedAd.OnAdClosed += HandleRewardedAdClosed;
    }

    public float SetX = -91f;
    public float SetY = 1044f;

    void Update()
    {
        if (rewarded)               //�����带 ���� �� �ְ� �Ǹ�
        {
            //�����
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
        if (rewardedAd.IsLoaded())          //���� �غ�Ǹ�
        {
            rewardedAd.Show();          //���� �����ֱ�
        }
    }

    public void CreateAndLoadRewardedAd()       //���� �ٽ� �ε�
    {
        rewardedAd = new RewardedAd(rewardID);

        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;        //������ ���� ������ ������
        rewardedAd.OnAdClosed += HandleRewardedAdClosed;            //������ ���� ������ ��������

        AdRequest request = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(request);
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)       //����ڰ� ���� �ݾ��� ��
    {
        CreateAndLoadRewardedAd();              //���� �ٽ� �ε�
    }

    private void HandleUserEarnedReward(object sender, Reward e)            //���� �� ���� ��
    {
        rewarded = true;
    }
}
