using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePauseImg : MonoBehaviour
{
    public Image TargetImage;       //기존에 존재하는 이미지
    public Sprite TargetSprite1;       //바뀌어질 이미지
    public Sprite TargetSprite2;       //바뀌어질 이미지

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
