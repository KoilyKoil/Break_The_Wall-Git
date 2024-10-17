using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Move : MonoBehaviour
{
    //�̷�
    //���� �������� �̹����� �̵���Ű��, ����Ʈ ���� �����ϸ� �̹����� ���� ��ġ�� ����
    //���� ��ġ ���� ���� �����ϰԲ� �����ϸ� ���� ��?
    //��<-��� ������
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
