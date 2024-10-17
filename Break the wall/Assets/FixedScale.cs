using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetResolution();
    }

    public void SetResolution()
    {
        int setWidth = 720;                         //사용자 설정 너비(가로)
        int setHeight = 1080;                       //사용자 설정 높이(세로)

        int deviceWidth = Screen.width;     //기기의 너비 저장
        int deviceHeight = Screen.height;   //기기의 높이 저장

        Screen.SetResolution(setWidth, (int)(((float)deviceHeight / deviceWidth) * setWidth), true);    //제대로된 함수 사용

        if ((float)setWidth / setHeight < (float)deviceWidth / deviceHeight)        //사용자 설정비<기기 화면비
        {
            float newWidth = ((float)setWidth / setHeight) / ((float)deviceWidth / deviceHeight);       //새로운 너비
            Camera.main.rect = new Rect((1f - newWidth) / 2f, 0f, newWidth, 1f);    //새로운 rect적용
        }
        else                //사용자 설정비>기기 화면비
        {
            float newHeight = ((float)deviceWidth / deviceHeight) / ((float)setWidth / setHeight);       //새로운 높이
            Camera.main.rect = new Rect(0f, (1f-newHeight)/2f, 1f, newHeight );    //새로운 rect적용
        }
    }
}
