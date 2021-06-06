using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float waitingTime = 1.5f;
    public bool ready = true;
    public bool end = false;
    public GameObject cactus;
    public GameObject bird;
    public AudioClip deathSound;
    public AudioClip goalSound;
    public int score;
    public TextMesh scoreText;
    public TextMesh finishScoreText;
    public TextMesh bestScoreText;
    public GameObject getReadyImg;
    public GameObject readyTapImg;
    public GameObject gameoverImg;
    public GameObject finishWindow;
    public GameObject newImg;

    private Rigidbody birdRb;
    private AudioSource audioSource;

    private void Awake()
    {
        Screen.SetResolution(1920, 1200, false);
    }

    void Start()
    {
        birdRb = bird.GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip ac)
    {
        audioSource.clip = ac;
        audioSource.Play();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && ready == true)
        {
            ready = false;
            InvokeRepeating("MakeCactus", 1f, waitingTime);
            birdRb.useGravity = true;
            iTween.FadeTo(getReadyImg, iTween.Hash("alpha", 0, "time", 0.5f));
            iTween.FadeTo(readyTapImg, iTween.Hash("alpha", 0, "time", 0.5f));
        }

        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
    }

    public void GameOver()
    {
        if (end) return;
        // 게임종료 시 실행할 명령은 여기로
        end = true;
        CancelInvoke("MakeCactus");
        iTween.ShakePosition(Camera.main.gameObject,
            iTween.Hash("x", 0.2, "y", 0.2, "time", 0.5f));
        iTween.FadeTo(gameoverImg, iTween.Hash("alpha", 255, "delay", 1f, "time", 0.5f));
        iTween.MoveTo(finishWindow, iTween.Hash("y", 1, "delay", 1.3f, "time", 0.5f));
        PlaySound(deathSound);

        if(score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", score);
            newImg.SetActive(true);
        } else if(score <= PlayerPrefs.GetInt("BestScore"))
        {
            newImg.SetActive(false);
        }

        finishScoreText.text = score.ToString();
        bestScoreText.text = PlayerPrefs.GetInt("BestScore").ToString();
    }

    public void GetScore()
    {
        PlaySound(goalSound);
        score += 1;
        scoreText.text = score.ToString();
    }

    void MakeCactus()
    {
        Instantiate(cactus);
    }
}
