using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private float gameSessionTimer;
    void Start()
    {
        Time.timeScale = 1;
        gameSessionTimer = PlayerPrefs.GetInt("SessionTime");
        gameSessionTimer *= 60;
    }

    // Update is called once per frame
    void Update()
    {
        CheckTimer();
    }
    private void CheckTimer()
    {
        
        gameSessionTimer -= Time.deltaTime;

        if (gameSessionTimer <= 0)
            GameOver();
    }
    public void GameOver()
    {
        scoreManager.SaveScore();
        Time.timeScale = 0;
    }

    //public int GameSessionTimer { get { return gameSessionTimer; } }
}
