using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMove : MonoBehaviour
{

    public float SpikeSpeed = 5.6f;
    public float MaxSpeed = 11f;
    //public float SpikeLimit = -40f;

    private void Update()
    {
        if (GameManager.score % 500 == 0 && GameManager.score >= 500)
        {
            if (SpikeSpeed < MaxSpeed)
            {
                SpikeSpeed += 0.2f;
            }
        }
        transform.Translate(-SpikeSpeed * Time.deltaTime, 0, 0);    //x축 방향으로 이동시킴

        /*
        if (transform.position.x <= SpikeLimit)        //오브젝트 파괴
        {
            transform.Translate(50f, 0, 0);    //x축 방향으로 이동시킴
            //SpikeSpeed+=1f;
            //Destroy(gameObject);
        }
        */ 
    }

    /*
    private void OnDisabled()
    {
        transform.Translate(50f, 0, 0);    //x축 방향으로 이동시킴
    }
    */
}
