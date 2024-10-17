using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeJumpImg : MonoBehaviour
{
    public Image TargetImage;       //기존에 존재하는 이미지
    public Sprite TargetSprite;       //바뀌어질 이미지

    public void ChangeJumpImage()
    {
            TargetImage.sprite = TargetSprite;
    }
}
