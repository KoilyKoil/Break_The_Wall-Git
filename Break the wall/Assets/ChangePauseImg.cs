using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePauseImg : MonoBehaviour
{
    public Image TargetImage;       //������ �����ϴ� �̹���
    public Sprite TargetSprite1;       //�ٲ���� �̹���
    public Sprite TargetSprite2;       //�ٲ���� �̹���

    public void ChangeImage()
    {
        if (Time.timeScale == 0)
        {
            TargetImage.sprite = TargetSprite1;
        }
        else
        {
            TargetImage.sprite = TargetSprite2;
        }
    }
}
