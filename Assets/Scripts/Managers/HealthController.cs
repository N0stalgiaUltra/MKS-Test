using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public enum CharType
    {
        PLAYER,
        ENEMY
    }

    [SerializeField] private CharType charType;
    [SerializeField] private ShipData shipData;
    [SerializeField] private ShipDamage shipDamage;
    [SerializeField] private int health;

    [SerializeField] private GameObject explosionAnimation;
    
    
    [SerializeField] private EnemyPooling enemyPooling;
    private bool isDestroyed;

    private void Awake()
    {
        if(charType == CharType.ENEMY)
            enemyPooling = FindObjectOfType<EnemyPooling>();
    }
    void Start()
    {
        isDestroyed = false;
        SetHealth();
    }

    void Update()
    {
        if (health <= 0 && !isDestroyed)
            Die();
        
    }

    public void SetHealth() => this.health = shipData.TotalHealth;


    public void Damage(int value)
    {
        if (health > 0)
            health -= value;
        else
            return;
    }

    private void Die()
    {
        isDestroyed = true;
        Instantiate(explosionAnimation, this.transform.position, this.transform.rotation);
        shipDamage.InstantiateDestroyedShip();
        this.gameObject.SetActive(false);

        if (this.charType == CharType.PLAYER)
        {
            // TODO : ADD GAMEOVER AND SET SCORE
        }
        else
        {
            enemyPooling.ReplenishQueue(this.gameObject);
        }
    }
    

    
    public int Health { get { return health; } }
}
