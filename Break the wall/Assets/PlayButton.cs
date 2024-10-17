using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject ScoreObjt;
    public GameObject PauseObjt;
    public GameObject TitleObjt;
    public GameObject PlayObjt;
    public GameObject Tutorial_Panel;

    public void PlayBtn()
    {
        //�۵� ����
        ScoreObjt.SetActive(true);
        PauseObjt.SetActive(true);
        Tutorial_Panel.SetActive(true);
        Invoke("DestroyPanel", 2f);
        DataManager.PlayerDie = false;
        DataManager.OnPlay = true;

        //�۵� ����
        TitleObjt.SetActive(false);
        PlayObjt.SetActive(false);
        GameManager.score = 0;
    }

    public void DestroyPanel()
    {
        Destroy(Tutorial_Panel);
    }
}
