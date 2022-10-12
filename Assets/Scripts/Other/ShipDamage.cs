using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipDamage : MonoBehaviour
{
    [Header ("Script References")]
    [SerializeField] private ShipSpriteData shipSpriteData;
    [SerializeField] private HealthController healthController;
    [SerializeField] private DestroyedShip destroyedShip;

    [Header ("Component References")]
    [SerializeField] private SpriteRenderer shipSR;

    void Start()
    {
        shipSR.sprite = shipSpriteData.sprites[0];
    }

    void Update()
    {

        if(healthController.Health < 50)
            shipSR.sprite = shipSpriteData.sprites[1];

        if (healthController.Health <= 25)
            shipSR.sprite = shipSpriteData.sprites[2];

    }

    public void InstantiateDestroyedShip() => Instantiate(destroyedShip, transform.position, transform.rotation).Setup(shipSpriteData.damagedSprite);

}

