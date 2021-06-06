using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ex4) ť�갡 �����ϸ� ���� �̵�(3.0f), x��ǥ�� -4���Ǹ� ���������� �̵�, x�� 4�� �Ѵ� ������ �ٽ� �������� �̵�, bool�� �ʿ�

public class LalaController : MonoBehaviour
{

    bool is_left = true;
    private void Start() // ������ ��
    {
        transform.position = new Vector3(0, 0, 0); // x,y,z�� ��ġ 0,0,0���� �̵�
    }

    private void Update()
    {
        if(is_left == true) // �� �ϋ�
        {
            transform.Translate(new Vector3(-3.0f * Time.deltaTime, 0, 0)); // �������� �̵�
        } else
        {
            transform.Translate(new Vector3(3.0f * Time.deltaTime, 0, 0)); // ���������� �̵�
        }

        if (transform.position.x < -4) is_left = false; // ���������� �̵�
        if (transform.position.x > 4) is_left = true; // �������� �̵�
    }
}
