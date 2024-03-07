using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Net.Mime;
using UnityEngine.UI;

public class PlayingGameLogicManagerScript : MonoBehaviour
{
    public Text playerScoreText;
    public Text BestScoreText;
    public int BestScore;
    public Text fpsText;
    public int playerScore = 0;
    public GameObject gameOverScreen;

    public float deltaTime;
    public float backGroundSpeed;
    
    
    public void Start()
    {
        Time.timeScale = 1;
        DisplayScoreText();
        DisplayBestScoreText();
    }

    public void DisplayBestScoreText()
    {
        BestScore = PlayerPrefs.GetInt("BestScore");
        BestScoreText.text =  "Best score: " + BestScore;

    }
    public void DisplayScoreText()
    {
        playerScoreText.text = playerScore.ToString();
    }
    public void AddScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        DisplayScoreText();
    }

    public void TogglePause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        fpsText.text = Mathf.Ceil(fps) + "fps";
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        TogglePause();
        if (playerScore > BestScore)
        {
            PlayerPrefs.SetInt("BestScore", playerScore);
        }
        DisplayBestScoreText();
    }
    
    public void NewGame()
    {
        SceneManager.LoadScene("PlayingScene");
    }

    public void GoToMainTitle()
    {
        SceneManager.LoadScene("MainTitle");
    }
}
