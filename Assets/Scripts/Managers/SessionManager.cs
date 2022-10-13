using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SessionManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private float time;

    private float minutes;
    private float seconds;

    private bool isTimerRunning;
    void Start()
    {
        time = PlayerPrefs.GetInt("SessionTime");
        isTimerRunning = true;
    }

    void Update()
    {
        if (isTimerRunning)
        {
            if(time > 0)
            {
                time -= Time.deltaTime;
                ShowTimer(time);
            }
            else
            {
                time = 0;
                isTimerRunning = false;
                gameManager.GameOver();
            }
        }
    }

    void ShowTimer(float aux)
    {
        aux += 1;
        minutes = aux;
        seconds = Mathf.FloorToInt(aux % 60);

        timeText.text = "Game Session Time " + string.Format("{0:00}: {1:00}", minutes, seconds);
    }
}
