using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeJumpImg : MonoBehaviour
{
    public Image TargetImage;       //������ �����ϴ� �̹���
    public Sprite TargetSprite;       //�ٲ���� �̹���

    public void ChangeJumpImage()
    {
            TargetImage.sprite = TargetSprite;
    }
}
