using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdateDetect : MonoBehaviour
{
    //충돌처리 및 충돌 존 진입 후 완전히 벗어나야 해당 됨
    //Exit2D를 Enter2D로 바꾸면 진입하자마자 해당
    //Stay2D는 충돌하고 있는 시간동안 지속
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (DataManager.OnPlay == true)
        {
            //Player 태그와 충돌할 시
            if (collision.gameObject.tag.CompareTo("Player") == 0)
            {
                GameManager.score++;        //게임매니저 스크립트 내의 점수 변수에 1을 더해줌
            }
        }
    }
}
