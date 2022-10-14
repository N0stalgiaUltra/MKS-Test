using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Controls the Health Bar inside the Ship´s own Canvas.
/// </summary>
public class HealthBar : MonoBehaviour
{
    [Header ("Script References")]
    [SerializeField] private HealthController healthController;
    [SerializeField] private ShipData shipData;
    [Header ("UI Reference")]
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
