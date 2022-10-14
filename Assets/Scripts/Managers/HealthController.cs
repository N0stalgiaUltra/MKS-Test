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

    private GameManager gameManager;
    private EnemyPooling enemyPooling;
    private bool isDestroyed;

    private void Awake()
    {
        if (charType == CharType.ENEMY)
            enemyPooling = FindObjectOfType<EnemyPooling>();
        else
            gameManager = FindObjectOfType<GameManager>();
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

        if (charType == CharType.PLAYER)
        {
            gameManager.GameOver();
        }
        else
        {
            enemyPooling.ReplenishQueue(this.gameObject);
            isDestroyed = false;
        }

    }

    public int Health { get { return health; } }
}
