using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipDamage : MonoBehaviour
{
    [SerializeField] private Sprite[] shipSprites = new Sprite[4];
    [SerializeField] private HealthController healthController;
    [SerializeField] private SpriteRenderer shipSR;
    void Start()
    {
        shipSR.sprite = shipSprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(healthController.Health <= 75)
            shipSR.sprite = shipSprites[1];

        if (healthController.Health <= 25)
            shipSR.sprite = shipSprites[2];
        
        if (healthController.Health <= 0)
            shipSR.sprite = shipSprites[3];
    }
}
