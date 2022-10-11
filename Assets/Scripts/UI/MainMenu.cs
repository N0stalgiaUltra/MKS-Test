using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
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

    // Update is called once per frame
    void Update()
    {
        
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
