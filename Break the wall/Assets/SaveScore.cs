using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class SaveScore : MonoBehaviour
{
    /*
    //������ �����
    public int TestScore = BestScoreData.bestscore;
    public int BestScore;

    public void SaveData()
    {
        PlayerPrefs.SetInt("BestScore", TestScore);
        PlayerPrefs.Save();
        Debug.Log("���� �Ϸ�!");
    }

    public void GetData()
    {
        BestScore = PlayerPrefs.GetInt("BestScore");
        BestScoreData.bestscore = BestScore;
        Debug.Log("�ҷ����� �Ϸ�!");
    }
    */
    /*
    //�̱��� (������ ��Ʈ�ѷ�=�� Ŭ������ ��üȭ�ؼ� ������ ��Ʈ�ѷ��� ��ũ��Ʈ�� ã�� �ʾƵ� �ٷ� ���� ������ ��)
    //�ε���
    public static GameObject _container;
    public static GameObject Container
    {
        get
        {
            return _container;
        }
    }

    //�ε���
    public static SaveScore _instance;
    public static SaveScore Instance
    {
        get
        {
            if (!_instance)
            {
                _container = new GameObject();
                _container.name = "SaveScore";
                _instance = _container.AddComponent(typeof(SaveScore)) as SaveScore;
                DontDestroyOnLoad(_container);          //�� �޼ҵ�� �� �̵��� �����ص� �����ʹ� �����ǰ� ����
            }
            return _instance;
        }
    }

    public string GameDataFileName = "BestScore.json";           //�����͸� ������ ���ϸ�

    //�ε���
    public BestScoreData _gameData;
    public BestScoreData gameData
    {
        get
        {
            if(_gameData == null)
            {
                LoadGameData();
                SaveGameData();
            }
            return _gameData;
        }
    }

    //���������� ����ϴ� �޼ҵ�

    public void LoadGameData()
    {
        string filePath = Application.persistentDataPath + GameDataFileName;        //���� ��ΰ� �ʱ�ȭ

        if (File.Exists(filePath))      //������ �ش� ��ο� �����ϸ�
        {
            string FromJsonData = File.ReadAllText(filePath);                           //���Ͽ� ����Ǿ��ִ� ��� �����͸� �о
            _gameData = JsonUtility.FromJson<BestScoreData>(FromJsonData);       //����Ǿ��ִ� �����͸� ����?
            Debug.Log("�ҷ����� ����");
        }
        else                        //��γ��� ������ ���� ��
        {
            _gameData = new BestScoreData();           //�ű� ���� ����
            Debug.Log("�ű� ���� ����");
        }
    }

    public void SaveGameData()
    {
        string ToJsonData = JsonUtility.ToJson(gameData);                               //�����Ͱ�
        string filePath = Application.persistentDataPath + GameDataFileName;   //���� ���
        File.WriteAllText(filePath, ToJsonData);                                                //�ش� ��ο� �ش� �����͸� ����ؼ� ���� ����
                                                                                                                          //�̹� ����Ǿ� �ִ� ������ ������ �������
        Debug.Log("���� �Ϸ�");
    }

    private void OnApplicationQuit()                            //�� �����
    {
        SaveGameData();                                                 //������ ����
    }
    */
}
