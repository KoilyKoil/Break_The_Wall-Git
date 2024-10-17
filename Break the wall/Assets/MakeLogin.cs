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
        //�ʱ�ȭ �Լ�. �ν��Ͻ� ��������
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        //����� �α� ��¿�
        PlayGamesPlatform.DebugLogEnabled = true;
        //���� ���� ���� Ȱ��ȭ
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

        //���� �α����� �ȵǾ�������
        if (!Social.localUser.authenticated)
        {
            Debug.Log("���� �õ�...");
            bWaitingForAuth = true;

            //�α��� ���� ó������ (�ݹ��Լ�)
            Social.localUser.Authenticate(AuthenticateCallback);
        }
        else
        {
            Debug.Log("���� ����");
        }
    }
    
    //���� callback
    private void AuthenticateCallback(bool success)
    {
        Debug.Log("�ε���");
        if (success)
        {
            Debug.Log("���� ������");
        }
        else
        {
            Debug.Log("�α��� ����");
        }
    }
    */
    
    public void DoLogin()
    {
        Social.localUser.Authenticate((bool success) =>
        {
            //�α��� ������
            if (success)
            {
                Debug.Log("���� ����->" + Social.localUser.userName);
            }
            //���н� �Ұ�
            else
            {
                Debug.Log("���� ����");
            }
        });
    }

    public void DoLogout()
    {
        PlayGamesPlatform.Instance.SignOut();
        //((PlayGamesPlatform)Social.Active).SignOut();
    }
    
    //�������� ���
    public void ShowLeaderBoard()
    {
        //���� ���� �Լ�
        //1������: ������ ����
        //2������: ������ ��� �������� ID��
        //3������: callback�Լ�
        Social.ReportScore(BestScoreData.bestscore, GPGSIds.leaderboard_best_score, (bool success) =>
            {
                if (success)
                {
                    Debug.Log("�������� �ε�����");
                }
                else
                {
                    Debug.Log("�������� �ε�����");
                }
            });
        Social.ShowLeaderboardUI();
    }
}
