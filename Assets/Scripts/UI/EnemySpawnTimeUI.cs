using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

/// <summary>
/// Controls the Enemy Spawn Time logic inside the "Settings Menu"
/// </summary>
public class EnemySpawnTimeUI : MonoBehaviour
{
    [Header ("UI References")]
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private Button addButton;
    [SerializeField] private Button subButton;
    private int count = 3;
    void Start()
    {
        if (!PlayerPrefs.GetInt("EnemySpawnTime").Equals(0))
            count = PlayerPrefs.GetInt("EnemySpawnTime");

        addButton.onClick.AddListener(Add);
        subButton.onClick.AddListener(Sub);

    }

    void Update()
    {
        timeText.text = $"{count} Seconds";
        if (count >= 20)
            addButton.interactable = false;
        else
            addButton.interactable = true;

        if (count <= 3)
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
        PlayerPrefs.SetInt("EnemySpawnTime", count);
        PlayerPrefs.Save();
    }
}
