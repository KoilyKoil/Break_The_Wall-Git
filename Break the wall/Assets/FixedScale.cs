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
        int setWidth = 720;                         //����� ���� �ʺ�(����)
        int setHeight = 1080;                       //����� ���� ����(����)

        int deviceWidth = Screen.width;     //����� �ʺ� ����
        int deviceHeight = Screen.height;   //����� ���� ����

        Screen.SetResolution(setWidth, (int)(((float)deviceHeight / deviceWidth) * setWidth), true);    //����ε� �Լ� ���

        if ((float)setWidth / setHeight < (float)deviceWidth / deviceHeight)        //����� ������<��� ȭ���
        {
            float newWidth = ((float)setWidth / setHeight) / ((float)deviceWidth / deviceHeight);       //���ο� �ʺ�
            Camera.main.rect = new Rect((1f - newWidth) / 2f, 0f, newWidth, 1f);    //���ο� rect����
        }
        else                //����� ������>��� ȭ���
        {
            float newHeight = ((float)deviceWidth / deviceHeight) / ((float)setWidth / setHeight);       //���ο� ����
            Camera.main.rect = new Rect(0f, (1f-newHeight)/2f, 1f, newHeight );    //���ο� rect����
        }
    }
}
