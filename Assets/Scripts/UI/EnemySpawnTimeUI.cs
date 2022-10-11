using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class EnemySpawnTimeUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private Button addButton;
    [SerializeField] private Button subButton;
    private int count = 3;
    void Start()
    {
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
    }

    private void Sub()
    {
        count--;
    }
}
