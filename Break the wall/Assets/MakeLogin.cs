using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class MakeLogin : MonoBehaviour
{

    private bool bWaitingForAuth = false;
    private void Awake()
    {
        //초기화 함수. 인스턴스 생성역할
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        //디버그 로그 출력용
        PlayGamesPlatform.DebugLogEnabled = true;
        //구글 관련 서비스 활성화
        PlayGamesPlatform.Activate();
    }
    
    /*
    private void Start()
    {
        DoAutoLogin();
    }

    public void DoAutoLogin()
    {
        if (bWaitingForAuth)
            return;

        //구글 로그인이 안되어있을때
        if (!Social.localUser.authenticated)
        {
            Debug.Log("인증 시도...");
            bWaitingForAuth = true;

            //로그인 인증 처리과정 (콜백함수)
            Social.localUser.Authenticate(AuthenticateCallback);
        }
        else
        {
            Debug.Log("인증 실패");
        }
    }
    
    //인증 callback
    private void AuthenticateCallback(bool success)
    {
        Debug.Log("로딩중");
        if (success)
        {
            Debug.Log("정보 가져옴");
        }
        else
        {
            Debug.Log("로그인 실패");
        }
    }
    */
    
    public void DoLogin()
    {
        Social.localUser.Authenticate((bool success) =>
        {
            //로그인 성공시
            if (success)
            {
                Debug.Log("인증 성공->" + Social.localUser.userName);
            }
            //실패시 할거
            else
            {
                Debug.Log("인증 실패");
            }
        });
    }

    public void DoLogout()
    {
        PlayGamesPlatform.Instance.SignOut();
        //((PlayGamesPlatform)Social.Active).SignOut();
    }
    
    //리더보드 출력
    public void ShowLeaderBoard()
    {
        //점수 보고 함수
        //1번인자: 보고할 정수
        //2번인자: 보고할 대상 리더보드 ID값
        //3번인자: callback함수
        Social.ReportScore(BestScoreData.bestscore, GPGSIds.leaderboard_best_score, (bool success) =>
            {
                if (success)
                {
                    Debug.Log("리더보드 로딩성공");
                }
                else
                {
                    Debug.Log("리더보드 로딩실패");
                }
            });
        Social.ShowLeaderboardUI();
    }
}
