using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonControl : MonoBehaviour
{
    public TextMesh scoreText;
    public int score;

    void Start()
    {
        score = 0;
        scoreText.text = "Score : " + score.ToString();
    }

    public void PlusScore()
    {
        score += 1;
        scoreText.text = "Score : " + score.ToString();
    }

    public void MlnusScore()
    {
        score -= 1;
        scoreText.text = "Score : " + score.ToString();
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = "Score : " + score.ToString();
    }

    void Update()
    {
      
    }
}
