using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private int highScore;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;
    void Start()
    {
        score = 0;
        highScore = PlayerPrefs.GetInt("Highscore");
        highScoreText.text = $"Highscore: {highScore}";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = $"Score: {score}";
    }

    public void AddScore()
    {
        score++;
    }
    
    public void SaveScore() 
    { 
        if(score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("Highscore", highScore);
            PlayerPrefs.Save();
        }
    }
    
    public int Score { get { return score; } }
    public int Highscore { get { return highScore; } }
}
