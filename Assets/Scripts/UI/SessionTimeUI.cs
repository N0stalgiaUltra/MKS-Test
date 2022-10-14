using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Controls the Session Time logic inside the "Settings Menu"
/// </summary>
public class SessionTimeUI : MonoBehaviour
{
    [Header ("UI References")]
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private Button addButton;
    [SerializeField] private Button subButton;
    private int count = 1;
    void Start()
    {
        if (!PlayerPrefs.GetInt("SessionTime").Equals(0))
            count = PlayerPrefs.GetInt("SessionTime");

        addButton.onClick.AddListener(Add);
        subButton.onClick.AddListener(Sub);

    }

    void Update()
    {
        timeText.text = $"{count} Minutes";
        if (count >= 3)
            addButton.interactable = false;
        else
            addButton.interactable = true;

        if (count <= 1)
            subButton.interactable = false;
        else
            subButton.interactable = true;
    }

    private void Add()
    {
        count++;
        Save();
    }

    private void Sub()
    {
        count--;
        Save();
    }
    private void Save()
    {
        PlayerPrefs.SetInt("SessionTime", count);
        PlayerPrefs.Save();
    }
}

