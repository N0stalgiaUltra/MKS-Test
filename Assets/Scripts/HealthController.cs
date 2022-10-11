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
    private bool isDestroyed;
    void Start()
    {
        health = shipData.TotalHealth;
        isDestroyed = false;
    }

    void Update()
    {
        if (health <= 0 && !isDestroyed)
            Die();
        
    }

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
        this.gameObject.SetActive(false);

        if (this.charType == CharType.PLAYER)
        {
            
        }
        //StartCoroutine(DestroyShip());
    }
    

    
    public int Health { get { return health; } }
}
