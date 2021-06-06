using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SphereController : MonoBehaviour
{
    public TextMeshPro timeText;
    public TextMesh scoreText;
    public int score;
    float _time;

    bool is_true;

    void Start()
    {
        timeText.text = "Time : 0.00";
        score = 0;
    }

    void Update()
    {
        if(is_true)
        {
            _time += Time.deltaTime;
            timeText.text = "Time : " + _time.ToString("N2"); // 소수점 2자리
        } else
        {
            _time = 0.0f;
            timeText.text = "Time : " + _time.ToString("N2");
        }

        

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * 3.0f * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * 3.0f * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other) // 들어갈 때
    {
     
    }

    void OnTriggerStay(Collider other) // 들어갈 때
    {
        is_true = true;

        if (other.CompareTag("LeftBox"))
        {
            if (_time > 1.5f)
            {
                score -= 1;
                scoreText.text = "Score : " + score.ToString();
            }
        }
        if (other.CompareTag("RightBox"))
        {
            if (_time > 1.5f)
            {
                score += 1;
                scoreText.text = "Score : " + score.ToString();
            }
        }
    }

    void OnTriggerExit(Collider other) // 탈출할 때
    {
        score = 0;
        scoreText.text = "Score : " + score.ToString();
        is_true = false;
    }
}
