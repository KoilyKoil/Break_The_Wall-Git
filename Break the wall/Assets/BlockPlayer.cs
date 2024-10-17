using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPlayer : MonoBehaviour
{
    //가시덤불 구현
    public GameObject GreatWall;
    public AnimeParameter state;
    public Animation anim;

    public void OnTriggerStay2D(Collider2D collision)
    {
        state = FindObjectOfType<AnimeParameter>();
        if (collision.gameObject.tag.CompareTo("Player") == 0) ;
        {
            if (state.StateofKick == true)
            {
                GreatWall.SetActive(true);
                Invoke("InActive", 3f);
            }
        }
    }

    public void InActive()
    {
        GreatWall.SetActive(false);
    }
}
