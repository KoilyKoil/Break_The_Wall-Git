using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdateDetect : MonoBehaviour
{
    //�浹ó�� �� �浹 �� ���� �� ������ ����� �ش� ��
    //Exit2D�� Enter2D�� �ٲٸ� �������ڸ��� �ش�
    //Stay2D�� �浹�ϰ� �ִ� �ð����� ����
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (DataManager.OnPlay == true)
        {
            //Player �±׿� �浹�� ��
            if (collision.gameObject.tag.CompareTo("Player") == 0)
            {
                GameManager.score++;        //���ӸŴ��� ��ũ��Ʈ ���� ���� ������ 1�� ������
            }
        }
    }
}
