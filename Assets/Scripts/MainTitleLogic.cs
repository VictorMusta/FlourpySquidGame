using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainTitleLogic : MonoBehaviour
{
    public Text BestScoreText;
    public int BestScore;
    private void Start()
    {
        Time.timeScale = 1;
        DisplayBestScoreText();
    }
    public void DisplayBestScoreText()
    {
        BestScore = PlayerPrefs.GetInt("BestScore");
        BestScoreText.text =  "Best score: " + BestScore;

    }
    public void PlayGame()
    {
        SceneManager.LoadScene("PlayingScene");
    }
    
    public void ResetHighScore()
    {
        PlayerPrefs.SetInt("BestScore", 0);
        DisplayBestScoreText();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
}

