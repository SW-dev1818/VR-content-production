using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ex2) A Ű�� ������ 2,0,0���� �̵�/B Ű�� ������ -2,0,0���� �̵�/C Ű�� ���� �� �����ϰ� �̵�/DŰ�� ���� �� 3.0f �ڿ������� �̵�

public class CubeController : MonoBehaviour // ����
{
    void Start()
    {
        this.transform.position = new Vector3(0, 0, 0); // ��ġ ��
    }

    void Update()
    {
        if(transform.position.x < -3)
        {
            transform.Translate(new Vector3(2.0f * Time.deltaTime, 0, 0));
        }

        //if(Input.GetKeyDown(KeyCode.A)) 
        //{
        //    this.transform.position = new Vector3(2, 0, 0); // ��ġ ��
        //}
       // if(Input.GetKeyDown(KeyCode.B)) 
        //        {
        //    this.transform.position = new Vector3(-2, 0, 0); // ��ġ ��
       // }
       // if(Input.GetKeyDown(KeyCode.C)) 
       // {
       //     float rnd = Random.Range(-5.0f, 5.0f); // ���� �� ����
       //     this.transform.position = new Vector3(rnd, 0, 0); // ��ġ ��
       // }
       // if (Input.GetKey(KeyCode.D)) 
       // {
       //     this.transform.Translate(new Vector3(3.0f * Time.deltaTime, 0, 0)); // �ڿ������� �̵�
       // }
       // if (Input.GetKey(KeyCode.E))
       // {
       //     this.transform.Translate(new Vector3(-3.0f * Time.deltaTime, 0, 0)); // �ڿ������� �̵�
       // }
   }
}
