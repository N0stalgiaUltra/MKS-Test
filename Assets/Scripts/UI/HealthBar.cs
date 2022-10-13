using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private HealthController healthController;
    [SerializeField] private ShipData shipData;
    [SerializeField] private Image damageBar;

    void Start()
    {
        damageBar.fillAmount = (float)healthController.Health / shipData.TotalHealth;
    }

    void Update()
    {
        damageBar.fillAmount = (float)healthController.Health / shipData.TotalHealth;

    }
}
