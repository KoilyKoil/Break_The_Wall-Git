using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEW_PCInput : MonoBehaviour
{
    //PC에서의 조작 처리
    MakeJump makeJump;
    AnimeParameter animeParameter;

    [SerializeField] KeyCode jumpKey = KeyCode.Z;
    [SerializeField] KeyCode slideKey = KeyCode.X;
    [SerializeField] KeyCode kickKey = KeyCode.C;

    void Awake()
    {
        makeJump = GetComponent<MakeJump>();
        animeParameter = GetComponent<AnimeParameter>();
    }

    void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            makeJump.J_Button();
            animeParameter.JumpOn();
        }
        if (Input.GetKeyDown(slideKey))
        {
            animeParameter.SlideOn();
        }else if (Input.GetKeyUp(slideKey))
        {
            animeParameter.SlideOff();
        }
        if (Input.GetKeyDown(kickKey))
        {
            animeParameter.KickOn();
        }else if (Input.GetKeyUp(kickKey))
        {
            animeParameter.KickOff();
        }
    }
}
