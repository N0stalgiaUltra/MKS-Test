using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private float gameSessionTimer;
    [SerializeField] private GameObject gameOverScreen;
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
