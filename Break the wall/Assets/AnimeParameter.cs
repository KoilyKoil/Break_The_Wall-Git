using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeParameter : MonoBehaviour
{
    public Animator animator;
    public bool StateofKick = false;
    public bool StateofSlide = false;

    public void JumpOn()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("JumpState", true);
        animator.Play("JumpAnim", -1, 0f);
    }

    public void JumpOff()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("JumpState", false);
    }


    public void SlideOn()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("SlideState", true);
        StateofSlide = true;
    }
    public void SlideOff()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("SlideState", false);
        StateofSlide = false;
    }

    public void KickOn()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("KickState", true);
        StateofKick = true;
    }
    public void KickOff()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("KickState", false);
        StateofKick = false;
    }
}
