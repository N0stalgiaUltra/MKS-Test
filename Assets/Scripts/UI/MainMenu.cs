using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Main Menu Script, Holds references to the play and settings buttons.
/// </summary>
public class MainMenu : MonoBehaviour
{
    [Header ("UI References")]
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button cancelButton;
    [SerializeField] private GameObject settingsScreen;
    bool isOpen;
    void Start()
    {
        isOpen = false;
        playButton.onClick.AddListener(Play);
        settingsButton.onClick.AddListener(Settings);
        cancelButton.onClick.AddListener(Settings);
    }

    void Play()
    {
        SceneManager.LoadScene(1);
    }

    void Settings()
    {
        settingsScreen.SetActive(isOpen = !isOpen);
    }
}
