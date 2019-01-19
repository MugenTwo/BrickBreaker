﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    [Range(0.1f,10f)]
    [SerializeField]
    float gameSpeed = 1f;
    [SerializeField]
    int pointsPerBrickDestroyed = 10;
    [SerializeField]
    TextMeshProUGUI scoreText;

    [SerializeField]
    int currentScore = 0;

    void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += pointsPerBrickDestroyed;
        scoreText.text = currentScore.ToString();
    }
}