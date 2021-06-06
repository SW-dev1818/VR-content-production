using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public enum GameState
{
    ready,
    play,
    end
}

public class GameManager : MonoBehaviour
{
    public GameState gameState;
    public AudioClip readySound;
    public AudioClip goSound;
    public int gameScore;
    public TextMeshPro gameScoreText;
    public float limitTime;
    public TextMeshPro timeText;
    public GameObject black;
    public GameObject gameoverWindow;
    public TextMeshPro endscoreText;
    public TextMeshPro highscoreText;
    public GameObject resetBtn;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        SoundPlay(readySound);
        gameScoreText.text = gameScore.ToString();
        timeText.text = limitTime.ToString("N2");
        resetBtn.SetActive(false);
    }

    public void SoundPlay(AudioClip ac)
    {
        audioSource.clip = ac;
        audioSource.Play();
    }

    public void Go()
    {
        gameState = GameState.play;
        SoundPlay(goSound);
    }
    
    void Update()
    {
        if(gameState == GameState.play)
        {
            limitTime -= Time.deltaTime;
            if(limitTime <= 0)
            {
                limitTime = 0;
                GameOver();
                // °ÔÀÓ ³¡!!!!
            }
            timeText.text = limitTime.ToString("N2");
            gameScoreText.text = gameScore.ToString();        }
    }
    
    public void GameOver()
    {
        gameState = GameState.end;
        iTween.FadeTo(black, iTween.Hash(
            "alpha", 180, "delay", 0.1f, "time", 0.5f));
        iTween.MoveTo(gameoverWindow, iTween.Hash(
            "y", 0, "delay", 0.5f, "time", 0.5f));

        if(gameScore > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", gameScore);
        }

        endscoreText.text = gameScore.ToString();
        highscoreText.text = PlayerPrefs.GetInt("BestScore").ToString();
        resetBtn.SetActive(true);
    }

    public void Reset()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
