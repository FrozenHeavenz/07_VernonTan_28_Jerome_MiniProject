﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int Score;
    public static int Hp;

    public string sceneName;
    public Animator transAni;
    public Text Score_txt;
    public Text Hp_Txt;
    public GameObject pauseMenuUI;
    public GameObject gameOverUI;
    public GameObject nextLevelUI;

    public bool pause = false;
    public bool GameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.SetActive(false);
        nextLevelUI.SetActive(false);
        Time.timeScale = 1;
        Score = 0;
        Hp = 20;
    }

    // Update is called once per frame
    void Update()
    {
        Updatehealth();
        Updatescore();
    }

    public void Updatehealth()
    {   
        Hp_Txt.text = "Health : " + Hp;
    }

    public void Updatescore()
    {
        Score_txt.text = "Score : " + Score;
    }

    public void ScoreCheck()
    {
        if(Score >= 15)
        {
            StartCoroutine(Transistion());
            Time.timeScale = 0;
            nextLevelUI.SetActive(true);
            SceneManager.LoadScene("GameSceneLvl2");
        }
    }

    public void healthCheck()
    {
        if(Hp <= 0)
        {
            StartCoroutine(Transistion());
            Time.timeScale = 0;
            gameOverUI.SetActive(true);
            SceneManager.LoadScene(sceneName);
        }
    }

    public void Resume()
    {
        pause = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pause = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }


    IEnumerator Transistion()
    {
        transAni.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Main Menu");
    }

}
