using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadZone : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject LoadMap;
    public BoxCollider2D boxcol;
     

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (DataManager.PlayerDie == false)
        {
            if (collision.gameObject.tag.CompareTo("Player") == 0)
            {
                //다음 패턴 불러내기
                //gameManager.GetComponent<GameManager>().Next_Pattern();
                //Close1초뒤에 로드맵 끄기
                Invoke("Close", 1.5f);
                
            }
        }
    }

    /*
    float timer;
    int waitingTime;

    public void Start()                                     //최초 초기화
    {
        timer = 0f;
        waitingTime = 4;
    }
    public void Update()                                    //지속실행
    {
        if (DataManager.PlayerDie == false)
        {
            timer += Time.deltaTime;                    //시간이 흐를때마다 타이머 값 증가

            if (timer > waitingTime)                       //2초 경과시
            {
                gameManager.GetComponent<GameManager>().Next_Pattern();         //패턴 호출
                timer = 0;                                      //타이머를 0으로 초기화
            }
        }
    }
    */
    public void Close()
    {
        boxcol = GetComponent<BoxCollider2D>();
        boxcol.enabled = false;
    }
}
