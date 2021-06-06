using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    Animator ani;
    AudioSource audio;
    bool touchPossible = false;
    bool isBomb = false;

    public AudioClip openSound;
    public AudioClip catchSound;
    public AudioClip bombSound;

    public GameManager gameManager;

    void Start()
    {
        ani = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    public void Open()
    {
        touchPossible = true;
        audio.clip = openSound;
        audio.Play();

        if(gameManager.gameState == GameState.ready)
        {
            gameManager.Go();
        }
    }

    public void Close()
    {
        touchPossible = false;
    }

    private void OnMouseDown()
    {
        if(touchPossible)
        {
            touchPossible = false;
            ani.SetTrigger("isTouch");
            if(isBomb)
            {
                audio.clip = bombSound;
                audio.Play();
                gameManager.gameScore -= 200;
            } else
            {
                audio.clip = catchSound;
                audio.Play();
                gameManager.gameScore += 50;
            }
        }
    }

    public IEnumerator End()
    {
        float randomTime = Random.Range(1.0f, 3.0f);
        float randomD = Random.Range(0, 10f);
        yield return new WaitForSeconds(randomTime);

        if(gameManager.gameState != GameState.end)
        {
            if (randomD > 5.0f)
            {
                ani.SetTrigger("DuDaGi");
                isBomb = false;
            }
            else
            {
                ani.SetTrigger("Bomb");
                isBomb = true;
            }
        }
        
    }

    void Update()
    {
        
    }
}
