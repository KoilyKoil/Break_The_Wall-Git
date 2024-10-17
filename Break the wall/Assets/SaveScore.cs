using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class SaveScore : MonoBehaviour
{
    /*
    //데이터 저장용
    public int TestScore = BestScoreData.bestscore;
    public int BestScore;

    public void SaveData()
    {
        PlayerPrefs.SetInt("BestScore", TestScore);
        PlayerPrefs.Save();
        Debug.Log("저장 완료!");
    }

    public void GetData()
    {
        BestScore = PlayerPrefs.GetInt("BestScore");
        BestScoreData.bestscore = BestScore;
        Debug.Log("불러오기 완료!");
    }
    */
    /*
    //싱글톤 (데이터 컨트롤러=이 클래스를 객체화해서 데이터 컨트롤러의 스크립트를 찾지 않아도 바로 접근 가능케 함)
    //인덱서
    public static GameObject _container;
    public static GameObject Container
    {
        get
        {
            return _container;
        }
    }

    //인덱서
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
                DontDestroyOnLoad(_container);          //이 메소드로 씬 이동이 존재해도 데이터는 유지되게 해줌
            }
            return _instance;
        }
    }

    public string GameDataFileName = "BestScore.json";           //데이터를 저장할 파일명

    //인덱서
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

    //실질적으로 사용하는 메소드

    public void LoadGameData()
    {
        string filePath = Application.persistentDataPath + GameDataFileName;        //파일 경로값 초기화

        if (File.Exists(filePath))      //파일이 해당 경로에 존재하면
        {
            string FromJsonData = File.ReadAllText(filePath);                           //파일에 저장되어있는 모든 데이터를 읽어냄
            _gameData = JsonUtility.FromJson<BestScoreData>(FromJsonData);       //저장되어있는 데이터를 적용?
            Debug.Log("불러오기 성공");
        }
        else                        //경로내에 파일이 없을 시
        {
            _gameData = new BestScoreData();           //신규 파일 생성
            Debug.Log("신규 파일 생성");
        }
    }

    public void SaveGameData()
    {
        string ToJsonData = JsonUtility.ToJson(gameData);                               //데이터값
        string filePath = Application.persistentDataPath + GameDataFileName;   //파일 경로
        File.WriteAllText(filePath, ToJsonData);                                                //해당 경로에 해당 데이터를 기록해서 파일 저장
                                                                                                                          //이미 저장되어 있는 파일이 있으면 덮어씌어짐
        Debug.Log("저장 완료");
    }

    private void OnApplicationQuit()                            //앱 종료시
    {
        SaveGameData();                                                 //데이터 저장
    }
    */
}
