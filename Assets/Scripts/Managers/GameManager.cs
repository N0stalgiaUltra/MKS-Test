using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Responsible for controlling the game´s cycles
/// </summary>
public class GameManager : MonoBehaviour
{
    [Header ("Script References")]
    [SerializeField] private ScoreManager scoreManager;
    [Header ("Game Over Screen")]
    [SerializeField] private GameObject gameOverScreen;
    private float gameSessionTimer;

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
    private IEnumerator GameOverDelay()
    {
        yield return new WaitForSeconds(1f);
        scoreManager.SaveScore();
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;

    }
    public void GameOver()
    {
        StartCoroutine(GameOverDelay());
    }

}
