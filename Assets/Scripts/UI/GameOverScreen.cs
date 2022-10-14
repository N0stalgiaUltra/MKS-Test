using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Game Over Screen script, controls the logic behind game over.
/// </summary>
public class GameOverScreen : MonoBehaviour
{
    [Header("Script Reference")]
    [SerializeField] private ScoreManager scoreManager;

    [Header ("TextMesh References")]
    [SerializeField] private TextMeshProUGUI scoreText;   
    [SerializeField] private TextMeshProUGUI highScoreText;

    [Header ("Buttons References")]
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
