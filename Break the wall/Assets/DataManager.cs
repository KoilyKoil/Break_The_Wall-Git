using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static bool OnPlay = false;
    //���ο� ���� ���� ���
    static DataManager instance;
    public static DataManager Instance
    {
        get
        {
            return instance;
        }
    }

    public void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = null;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //���ӿ��� Ȯ�ο� ����
    public static bool PlayerDie = false;
}
