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
    public void GetHit()
    {
        if(this.enemyType == EnemyType.CHASER)
            enemyHealth.Damage(shipData.TotalHealth);
        // TODO: Set Explosion Animation, Eliminate
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { 
            GetHit(); 
        }
    }
}
