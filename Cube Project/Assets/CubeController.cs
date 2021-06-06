using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ex2) A 키를 누르면 2,0,0으로 이동/B 키를 누르면 -2,0,0으로 이동/C 키를 누를 시 랜덤하게 이동/D키를 누를 시 3.0f 자연스럽게 이동

public class CubeController : MonoBehaviour // 설명서
{
    void Start()
    {
        this.transform.position = new Vector3(0, 0, 0); // 위치 값
    }

    void Update()
    {
        if(transform.position.x < -3)
        {
            transform.Translate(new Vector3(2.0f * Time.deltaTime, 0, 0));
        }

        //if(Input.GetKeyDown(KeyCode.A)) 
        //{
        //    this.transform.position = new Vector3(2, 0, 0); // 위치 값
        //}
       // if(Input.GetKeyDown(KeyCode.B)) 
        //        {
        //    this.transform.position = new Vector3(-2, 0, 0); // 위치 값
       // }
       // if(Input.GetKeyDown(KeyCode.C)) 
       // {
       //     float rnd = Random.Range(-5.0f, 5.0f); // 랜덤 값 생성
       //     this.transform.position = new Vector3(rnd, 0, 0); // 위치 값
       // }
       // if (Input.GetKey(KeyCode.D)) 
       // {
       //     this.transform.Translate(new Vector3(3.0f * Time.deltaTime, 0, 0)); // 자연스럽게 이동
       // }
       // if (Input.GetKey(KeyCode.E))
       // {
       //     this.transform.Translate(new Vector3(-3.0f * Time.deltaTime, 0, 0)); // 자연스럽게 이동
       // }
   }
}
