using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ ť�긦 ���콺�� �� �� Ŭ���ϸ� �����ǰ� �� �� Ŭ���ϸ� �ٽ� ��Ÿ����

public class GameControl : MonoBehaviour
{
    bool is_true = true; // is_true��� bool ���� ������ ����

    public GameObject cube; // ���� ������Ʈ�� ť�� �� ����

    private void OnMouseDown()
    {
        if (is_true) // is_true�� ���ϋ�
        {
            cube.SetActive(false); // ť�� �����
            is_true = false; // is_true �������� ����
        }
        else
        {
            cube.SetActive(true); // ť�� ���̱�
            is_true = true; // is_True ������ ����
        }
    }
}
