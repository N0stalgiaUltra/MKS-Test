using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour, ICollider
{
    public enum EnemyType
    {
        CHASER,
        SHOOTER
    }
    [SerializeField] private HealthController enemyHealth;
    [SerializeField] private ShipData shipData;
    [SerializeField] private EnemyType enemyType;

    private int damage;
    public void GetHit(string objectTag)
    {
        if (objectTag.Equals("Player"))
        {
            if (this.enemyType == EnemyType.CHASER)
                enemyHealth.Damage(shipData.TotalHealth);
        }

        if (objectTag.Equals("Bullet"))
            enemyHealth.Damage(damage);
        // TODO: Set Explosion Animation, Eliminate
    }

    private void OnCollisionEnter2D(Collision2D collision) => GetHit(collision.gameObject.tag);


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
            damage = collision.gameObject.GetComponent<BulletLogic>().Damage;

        GetHit(collision.gameObject.tag);
    }
}
