using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Move : MonoBehaviour
{
    //이론
    //일정 방향으로 이미지를 이동시키고, 리미트 값에 도달하면 이미지를 원래 위치로 돌림
    //원래 위치 값도 설정 가능하게끔 선언하면 좋을 듯?
    //좌<-우는 음수값
    [SerializeField] float Speed = 3f;
    [SerializeField] float MaxSpeed = 5f;
    [SerializeField] float LimitPos = -20f;
    [SerializeField] float OrgPos = 20f;

    Vector2 startPos;
    float YforSave;

    void Start()
    {
        startPos = transform.position;
        YforSave = transform.position.y;
    }

    void Update()
    {
        if (DataManager.PlayerDie == false)
        {
            if (ZA_WARUDO.PauseState == false)
            {
                if (GameManager.score % 500 == 0 && GameManager.score >= 500)
                {
                    if (Speed < MaxSpeed)
                    {
                        Speed += 0.01f;
                    }
                }
                startPos = startPos - Vector2.right * Speed;

                if (transform.position.x <= LimitPos)
                {
                    startPos = new Vector2(OrgPos, YforSave);
                }
                transform.position = startPos;
            }
        }
    }
}
