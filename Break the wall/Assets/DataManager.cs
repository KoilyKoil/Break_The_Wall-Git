using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static bool OnPlay = false;
    //새로운 변수 접근 방식
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

    //게임오버 확인용 변수
    public static bool PlayerDie = false;
}
