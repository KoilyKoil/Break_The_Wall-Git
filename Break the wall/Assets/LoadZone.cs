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
                //���� ���� �ҷ�����
                //gameManager.GetComponent<GameManager>().Next_Pattern();
                //Close1�ʵڿ� �ε�� ����
                Invoke("Close", 1.5f);
                
            }
        }
    }

    /*
    float timer;
    int waitingTime;

    public void Start()                                     //���� �ʱ�ȭ
    {
        timer = 0f;
        waitingTime = 4;
    }
    public void Update()                                    //���ӽ���
    {
        if (DataManager.PlayerDie == false)
        {
            timer += Time.deltaTime;                    //�ð��� �带������ Ÿ�̸� �� ����

            if (timer > waitingTime)                       //2�� �����
            {
                gameManager.GetComponent<GameManager>().Next_Pattern();         //���� ȣ��
                timer = 0;                                      //Ÿ�̸Ӹ� 0���� �ʱ�ȭ
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
