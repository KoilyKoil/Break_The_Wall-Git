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
            //광고가 끝난 뒤 콜백함수 "HandleShowResult" 호출
                var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show("rewardedVideo", options);       //광고 출력
        }
    }

    //광고 종료 후 호출되는 콜백함수
    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                //보상
                DataManager.PlayerDie = false;
                ContinueButton.SetActive(false);
                GameOverPanel.SetActive(false);
                Player.transform.position = new Vector3(-91f, 1044f, 0f);
                Time.timeScale = 1;
                break;

            case ShowResult.Skipped:
                //스킵됐을시 대응책
                break;

            case ShowResult.Failed:
                //광고가 없을시 대응책
                break;
        }
    }
}
