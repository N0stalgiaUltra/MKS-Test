using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;

    [SerializeField] private TextMeshProUGUI scoreText;   
    [SerializeField] private TextMeshProUGUI highScoreText;

    [SerializeField] private Button playAgainButton;
    [SerializeField] private Button mainMenuButton;

    void Start()
    {
        playAgainButton.onClick.AddListener(Retry);
        mainMenuButton.onClick.AddListener(BackToMenu);

        scoreText.text = $"Your Score: {scoreManager.Score}";
        highScoreText.text = $"Highscore: {scoreManager.Highscore}";
    }


    private void BackToMenu() => SceneManager.LoadScene(0);

    private void Retry() => SceneManager.LoadScene(1);
}
