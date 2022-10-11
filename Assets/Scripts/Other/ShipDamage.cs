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
    
    [SerializeField] private Sprite[] shipSprites = new Sprite[4];
    [SerializeField] private HealthController healthController;
    [SerializeField] private SpriteRenderer shipSR;
    [SerializeField] private ShipType shipType;

    
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
            shipSR.sprite = shipSprites[3];
            DisableComponents();
        }
    }

    public void DisableComponents() 
    {
        if (this.shipType.Equals(ShipType.PLAYER))
        {
            //GetComponent<Rigidbody2D>().Sleep();
            GetComponent<PlayerMovement>().enabled = false;
            GetComponent<PlayerRotation>().enabled = false;
            GetComponent<PlayerShoot>().enabled = false;
            GetComponent<PlayerCollider>().enabled = false;

        }
        else if(this.shipType.Equals(ShipType.CHASER))
        {
            GetComponent<ChaserMovement>().enabled = false;
            GetComponent<EnemyCollider>().enabled = false;
            //GetComponent<EnemyShoot>().enabled = false;

        }
        else
        {
            GetComponent<ShooterMovement>().enabled = false;
            GetComponent<EnemyCollider>().enabled = false;
        }
    }
    public void EnableComponents() 
    {
        if (this.shipType.Equals(ShipType.PLAYER))
        {
            //GetComponent<Rigidbody2D>().Sleep();
            GetComponent<PlayerMovement>().enabled = true;
            GetComponent<PlayerRotation>().enabled = true;
            GetComponent<PlayerShoot>().enabled = true;
            GetComponent<PlayerCollider>().enabled = true;

        }
        else if(this.shipType.Equals(ShipType.CHASER))
        {
            GetComponent<ChaserMovement>().enabled = true;
            GetComponent<EnemyCollider>().enabled = true;

        }
        else
        {
            GetComponent<ShooterMovement>().enabled = true;
            GetComponent<EnemyCollider>().enabled = true;
            GetComponent<EnemyShoot>().enabled = true;
        }
    }
}
