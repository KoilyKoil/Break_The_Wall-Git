using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColliderSize : MonoBehaviour
{
    public AnimeParameter statue;
    public CapsuleCollider2D capcol;
    public BoxCollider2D boxcol;

    public void Start()
    {
        capcol = GetComponent<CapsuleCollider2D>();
        boxcol = GetComponent<BoxCollider2D>();
    }

    public void Update()
    {
        if (statue.StateofSlide == true)
        {
            capcol.enabled = false;
            boxcol.enabled = true;
        }
        else if (statue.StateofSlide == false)
        {
            capcol.enabled = true;
            boxcol.enabled = false;
        }
    }
}
