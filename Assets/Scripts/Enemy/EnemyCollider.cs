using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls all the enemy collisions
/// </summary>
public class EnemyCollider : MonoBehaviour, ICollider
{
    public enum EnemyType
    {
        CHASER,
        SHOOTER
    }
    [Header ("Script References")]
    [SerializeField] private HealthController enemyHealth;
    [SerializeField] private ShipData shipData;
    [Header ("Enemy Type")]
    [SerializeField] private EnemyType enemyType;
    private ChaserMovement chaserMovement;
    private ShooterMovement shooterMovement;
    private float enemySpeed;
    private int damage;

    private void Start()
    {
        if (this.enemyType == EnemyType.CHASER)
        {
            chaserMovement = GetComponent<ChaserMovement>();
        }
        else
        {
            shooterMovement = GetComponent<ShooterMovement>();

        }
        enemySpeed = shipData.Speed;
    }

    public void GetCollision(string objectTag)
    {
        if (objectTag.Equals("Island"))
        {
            ChangeEnemySpeed(0f);

        }

        if (objectTag.Equals("Sea"))
        {
            ChangeEnemySpeed(enemySpeed /= 2f);
        }


        if (objectTag.Equals("Player"))
        {
            if (this.enemyType == EnemyType.CHASER)
                enemyHealth.Damage(shipData.TotalHealth);
        }

        if (objectTag.Equals("Bullet"))
            enemyHealth.Damage(damage);
    }

    public void OutCollision()
    {
        ChangeEnemySpeed(shipData.Speed);
    }
    private void ChangeEnemySpeed(float newSpeed)
    {
        print(newSpeed);
        if (this.enemyType == EnemyType.CHASER)
            chaserMovement.Speed = newSpeed;
        else
            shooterMovement.Speed = newSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision) => GetCollision(collision.gameObject.tag);


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
            damage = collision.gameObject.GetComponent<BulletLogic>().Damage;

        GetCollision(collision.gameObject.tag);
    }

    private void OnTriggerExit2D(Collider2D collision) => OutCollision();

}
