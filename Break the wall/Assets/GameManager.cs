using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;          //재시작 화면 호출을 위해 선언

public class GameManager : MonoBehaviour
{
    //점수 증가 구현
    static public int score = 0;            //실질적인 점수 변화 저장을 위함
    public Text ScoreText;              //점수값 변화를 위한 텍스트형 변수
    public Text EndScoreText;              //점수값 변화를 위한 텍스트형 변수
    public Text BestScoreText;              //점수값 변화를 위한 텍스트형 변수

    //게임오버 출력용
    public GameObject GameOverPanel;

    //타이머 구현
    float timer;
    int WaitingTime;

    private void Start()
    {
        BestScoreData.bestscore = PlayerPrefs.GetInt("BestScore");
        Debug.Log("불러오기 완료");
        //savescore = Callsvscr.GetComponent<SaveScore>();
        //savescore.GetData();
        timer = 2f;
        WaitingTime = 3;
    }

    //SaveScore 사용을 위함
    public GameObject Callsvscr;
    public SaveScore savescore;

    public GameObject MenuButton1, MenuButton2;
    public GameObject MenuButton3;

    private void Update()
    {
        ScoreText.text = score.ToString();  //텍스트 인스턴스 속 실제 텍스트를 점수값의 string형 반환으로 초기화

        if(score%500==0 && score>=500)
        {
            if(DisappearTime>2f)
            {
                DisappearTime-=0.1f;
            }
        }

        //게임오버 출력
        if (DataManager.OnPlay == true)
        {
            
            //게임 시작시 메뉴버튼 비활성화
            MenuButton1.SetActive(false);
            MenuButton2.SetActive(false);
            MenuButton3.SetActive(false);
            
            //패턴 호출 구현
            timer += Time.deltaTime;
            if (timer > WaitingTime)
            {
                //Invoke("Next_Pattern", 6f);
                Next_Pattern();
                timer = 0;
            }
            
            //스코어 기록 구현
            if (DataManager.PlayerDie == true) //플레이어가 죽으면
            {
                Time.timeScale = 0;
                EndScoreText.text = score.ToString();  //텍스트 인스턴스 속 실제 텍스트를 점수값의 string형 반환으로 초기화
                if (score > BestScoreData.bestscore)
                {
                    BestScoreData.bestscore = score;
                    PlayerPrefs.SetInt("BestScore", BestScoreData.bestscore);
                    PlayerPrefs.Save();
                    Debug.Log("저장 완료!");
                    //savescore = Callsvscr.GetComponent<SaveScore>();
                    //savescore.SaveData();
                }
                BestScoreText.text = BestScoreData.bestscore.ToString();  //텍스트 인스턴스 속 실제 텍스트를 점수값의 string형 반환으로 초기화
                GameOverPanel.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.SetInt("BestScore", BestScoreData.bestscore);
            PlayerPrefs.Save();
            //savescore = Callsvscr.GetComponent<SaveScore>();
            //savescore.SaveData();
            Application.Quit();
        }
    }

    //재시작 버튼 작동용
    public void Restart_Btn()
    {
        //DataManager.Instance.
        score = 0;
        Time.timeScale = 1;
        DataManager.PlayerDie = false;
        DataManager.OnPlay = false;
        
        //게임 재시작시 메뉴버튼 활성화
        MenuButton1.SetActive(true);
        MenuButton2.SetActive(true);
        
        MenuButton3.SetActive(true);
        
        SceneManager.LoadScene("SampleScene");
    }

    //패턴 생성 구현
    public GameObject[] PatternMap; //패턴 배열로 보관
    public GameObject SpikeObj;
    public float DisappearTime=7.2f;

    public void Next_Pattern()
    {
        if (DataManager.OnPlay==true)
        {
            if (DataManager.PlayerDie == false)
            {
                int selectednumb = RandomSelectNumber();

                SpikeObj = (GameObject)Instantiate(PatternMap[selectednumb], new Vector3(0f, -19.3f, PatternMap[selectednumb].transform.position.z), PatternMap[selectednumb].transform.rotation);
                Destroy(SpikeObj.gameObject, DisappearTime);
            }
        }
    }

    public int RandomSelectNumber()
    {
        int rslt = Random.Range(0,9);
        return rslt;
    }
}
