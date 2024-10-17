using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeJump : MonoBehaviour
{

    public float jump = 10f;
    public int jumpCount = 0;
    public float temp=10f;

    public Animator animator;           //애니메이션 변경용

    public void J_Button()
    {
        if (jumpCount == 0)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump, 0);
            //Rigidbody2D의 코드를 불러내고, 거기서 해당 벡터를 변화시킴
            temp = jump;
            jumpCount++;
        }
        else
        {
            jump = 0f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Land") == 0)
        {
            animator = GetComponent<Animator>();                //파라미터를 가져옴
            animator.SetBool("JumpState", false);                //파라미터 조작
            jumpCount = 0;
            jump = temp;
        }
    }
}
