using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ArrowMove : MonoBehaviour
{
    bool is_fire = false;
    public float arrowSpeed;
    public int score;
    public int count;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI countText;
    public GameObject restartBtn;
    public TargetMove target;

    private Vector3 startPos;

    void Start()
    {
        score = 0;
        count = 5;
        arrowSpeed = 10.0f;
        startPos = transform.position;
        scoreText.text = "Score : 0";
        countText.text = "Count : " + count.ToString();
        restartBtn.SetActive(false);
    }

    void Update()
    {
        if (is_fire) transform.Translate(Vector3.right * arrowSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space)) is_fire = true;
    }

    public void GameOver()
    {
        // 게임종료 시 내용 추가
        restartBtn.SetActive(true);
        //Time.timeScale = 0; // 정지
        target.targetSpeed = 0;
    }

    public void ReStart()
    {
        SceneManager.LoadScene("Main");
        //Time.timeScale = 1; // 시작
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Score10")) score += 10;
        if (other.CompareTag("Score6")) score += 6;
        if (other.CompareTag("Score4")) score += 4;
        if (other.CompareTag("Score1")) score += 1;

        scoreText.text = "Score : " + score.ToString();
        count -= 1;
        countText.text = "Count : " + count.ToString();
        transform.position = startPos;
        is_fire = false;

        if (count == 0)
        {
            GameOver();
        }
    }
}