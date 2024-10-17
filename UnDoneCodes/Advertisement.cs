using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Advertisement : MonoBehaviour
{
    public GameObject GameOverPanel, Player, ContinueButton;

    public void ShowRewardedAd()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            //���� ���� �� �ݹ��Լ� "HandleShowResult" ȣ��
                var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show("rewardedVideo", options);       //���� ���
        }
    }

    //���� ���� �� ȣ��Ǵ� �ݹ��Լ�
    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                //����
                DataManager.PlayerDie = false;
                ContinueButton.SetActive(false);
                GameOverPanel.SetActive(false);
                Player.transform.position = new Vector3(-91f, 1044f, 0f);
                Time.timeScale = 1;
                break;

            case ShowResult.Skipped:
                //��ŵ������ ����å
                break;

            case ShowResult.Failed:
                //���� ������ ����å
                break;
        }
    }
}
