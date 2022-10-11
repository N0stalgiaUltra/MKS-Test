using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SessionTimeUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private Button addButton;
    [SerializeField] private Button subButton;
    private int count = 1;
    void Start()
    {
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
    }

    private void Sub()
    {
        count--;
    }
}

