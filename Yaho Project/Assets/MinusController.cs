using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MinusController : MonoBehaviour
{
    public TextMeshPro scoreText;
    public ScoreControl _score;

    void OnMouseDown() // 마우스를 눌렀을 때 동작
    {
        _score.score -= 1;
        scoreText.text = "Score : " + _score.score.ToString();
    }

    void Start()
    {
        scoreText.text = "Score : " + _score.score.ToString();
    }

    void Update()
    {
        
    }
}
