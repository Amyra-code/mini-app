using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int totalCoins;
    int currentScore = 0;

    public TextMeshProUGUI scoreText;
    public GameObject winText;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        totalCoins = GameObject.FindGameObjectsWithTag("coin").Length;
        UpdateScore();
        winText.SetActive(false);
    }

    public void AddScore()
    {
        currentScore++;
        UpdateScore();

        if(currentScore >= totalCoins)
        {
            winText.SetActive(true);
        }
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + currentScore;
    }
}
