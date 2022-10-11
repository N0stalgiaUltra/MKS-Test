using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipDamage : MonoBehaviour
{
    public enum ShipType
    {
        PLAYER,
        CHASER,
        SHOOTER
    }
    
    [SerializeField] private Sprite[] shipSprites = new Sprite[3];
    [SerializeField] private Sprite[] destroyedSprites = new Sprite[3];
    [SerializeField] private HealthController healthController;
    [SerializeField] private SpriteRenderer shipSR;
    [SerializeField] private ShipType shipType;
    [SerializeField] private DestroyedShip destroyedShip;
    private void Awake()
    {
        EnableComponents();

    }
    void Start()
    {
        shipSR.sprite = shipSprites[0];
    }

    // Update is called once per frame
    void Update()
    {

        if(healthController.Health < 50)
            shipSR.sprite = shipSprites[1];

        if (healthController.Health <= 25)
            shipSR.sprite = shipSprites[2];
        
        if (healthController.Health <= 0)
        {
            DisableComponents();
        }
    }

    public void DisableComponents() 
    {
        if(this.shipType.Equals(ShipType.CHASER))
            Instantiate(destroyedShip, transform.position, transform.rotation).Setup(destroyedSprites[1]);

    }
    public void EnableComponents() 
    {

    }
}

