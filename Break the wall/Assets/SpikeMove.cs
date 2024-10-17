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
        transform.Translate(-SpikeSpeed * Time.deltaTime, 0, 0);    //x�� �������� �̵���Ŵ

        /*
        if (transform.position.x <= SpikeLimit)        //������Ʈ �ı�
        {
            transform.Translate(50f, 0, 0);    //x�� �������� �̵���Ŵ
            //SpikeSpeed+=1f;
            //Destroy(gameObject);
        }
        */ 
    }

    /*
    private void OnDisabled()
    {
        transform.Translate(50f, 0, 0);    //x�� �������� �̵���Ŵ
    }
    */
}
