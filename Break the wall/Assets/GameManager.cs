using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;          //����� ȭ�� ȣ���� ���� ����

public class GameManager : MonoBehaviour
{
    //���� ���� ����
    static public int score = 0;            //�������� ���� ��ȭ ������ ����
    public Text ScoreText;              //������ ��ȭ�� ���� �ؽ�Ʈ�� ����
    public Text EndScoreText;              //������ ��ȭ�� ���� �ؽ�Ʈ�� ����
    public Text BestScoreText;              //������ ��ȭ�� ���� �ؽ�Ʈ�� ����

    //���ӿ��� ��¿�
    public GameObject GameOverPanel;

    //Ÿ�̸� ����
    float timer;
    int WaitingTime;

    private void Start()
    {
        BestScoreData.bestscore = PlayerPrefs.GetInt("BestScore");
        Debug.Log("�ҷ����� �Ϸ�");
        //savescore = Callsvscr.GetComponent<SaveScore>();
        //savescore.GetData();
        timer = 2f;
        WaitingTime = 3;
    }

    //SaveScore ����� ����
    public GameObject Callsvscr;
    public SaveScore savescore;

    public GameObject MenuButton1, MenuButton2;
    public GameObject MenuButton3;

    private void Update()
    {
        ScoreText.text = score.ToString();  //�ؽ�Ʈ �ν��Ͻ� �� ���� �ؽ�Ʈ�� �������� string�� ��ȯ���� �ʱ�ȭ

        if(score%500==0 && score>=500)
        {
            if(DisappearTime>2f)
            {
                DisappearTime-=0.1f;
            }
        }

        //���ӿ��� ���
        if (DataManager.OnPlay == true)
        {
            
            //���� ���۽� �޴���ư ��Ȱ��ȭ
            MenuButton1.SetActive(false);
            MenuButton2.SetActive(false);
            MenuButton3.SetActive(false);
            
            //���� ȣ�� ����
            timer += Time.deltaTime;
            if (timer > WaitingTime)
            {
                //Invoke("Next_Pattern", 6f);
                Next_Pattern();
                timer = 0;
            }
            
            //���ھ� ��� ����
            if (DataManager.PlayerDie == true) //�÷��̾ ������
            {
                Time.timeScale = 0;
                EndScoreText.text = score.ToString();  //�ؽ�Ʈ �ν��Ͻ� �� ���� �ؽ�Ʈ�� �������� string�� ��ȯ���� �ʱ�ȭ
                if (score > BestScoreData.bestscore)
                {
                    BestScoreData.bestscore = score;
                    PlayerPrefs.SetInt("BestScore", BestScoreData.bestscore);
                    PlayerPrefs.Save();
                    Debug.Log("���� �Ϸ�!");
                    //savescore = Callsvscr.GetComponent<SaveScore>();
                    //savescore.SaveData();
                }
                BestScoreText.text = BestScoreData.bestscore.ToString();  //�ؽ�Ʈ �ν��Ͻ� �� ���� �ؽ�Ʈ�� �������� string�� ��ȯ���� �ʱ�ȭ
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

    //����� ��ư �۵���
    public void Restart_Btn()
    {
        //DataManager.Instance.
        score = 0;
        Time.timeScale = 1;
        DataManager.PlayerDie = false;
        DataManager.OnPlay = false;
        
        //���� ����۽� �޴���ư Ȱ��ȭ
        MenuButton1.SetActive(true);
        MenuButton2.SetActive(true);
        
        MenuButton3.SetActive(true);
        
        SceneManager.LoadScene("SampleScene");
    }

    //���� ���� ����
    public GameObject[] PatternMap; //���� �迭�� ����
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
