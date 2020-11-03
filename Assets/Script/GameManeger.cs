using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{

    public int score;
    public Text ScoreText;

    public void Start()
    {
        ScoreText.text = score.ToString();
    }

    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
