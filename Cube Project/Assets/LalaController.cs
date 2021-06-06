using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ex4) 큐브가 시작하면 왼쪽 이동(3.0f), x좌표가 -4가되면 오른쪽으로 이동, x가 4가 넘는 순간에 다시 왼쪽으로 이동, bool값 필요

public class LalaController : MonoBehaviour
{

    bool is_left = true;
    private void Start() // 시작할 떄
    {
        transform.position = new Vector3(0, 0, 0); // x,y,z의 위치 0,0,0으로 이동
    }

    private void Update()
    {
        if(is_left == true) // 참 일떄
        {
            transform.Translate(new Vector3(-3.0f * Time.deltaTime, 0, 0)); // 왼쪽으로 이동
        } else
        {
            transform.Translate(new Vector3(3.0f * Time.deltaTime, 0, 0)); // 오른쪽으로 이동
        }

        if (transform.position.x < -4) is_left = false; // 오른쪽으로 이동
        if (transform.position.x > 4) is_left = true; // 왼쪽으로 이동
    }
}
