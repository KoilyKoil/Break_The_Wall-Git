using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashHitBox : MonoBehaviour
{
    //º® ÆÄ±« ±¸Çö
    public GameObject Block;
    public GameObject Broken_Block;
    public AnimeParameter state;
    public Animation anim;

    public void OnTriggerStay2D(Collider2D collision)
    {
        state = FindObjectOfType<AnimeParameter>();
        if (collision.gameObject.tag.CompareTo("Player") == 0);
        {
            if(state.StateofKick==true)
            {
                Instantiate(Broken_Block, transform.position, Quaternion.identity);
                Block.SetActive(false);
            }
        }
    }
}
