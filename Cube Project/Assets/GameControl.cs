using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 오른쪽 큐브를 마우스로 한 번 클릭하면 삭제되고 한 번 클릭하면 다시 나타나기

public class GameControl : MonoBehaviour
{
    bool is_true = true; // is_true라는 bool 값을 참으로 선언

    public GameObject cube; // 게임 오브젝트에 큐브 값 선언

    private void OnMouseDown()
    {
        if (is_true) // is_true가 참일떄
        {
            cube.SetActive(false); // 큐브 숨기기
            is_true = false; // is_true 거짓으로 변경
        }
        else
        {
            cube.SetActive(true); // 큐브 보이기
            is_true = true; // is_True 참으로 변경
        }
    }
}
