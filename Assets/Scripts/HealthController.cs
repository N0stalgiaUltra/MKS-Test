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
    void Start()
    {
        health = shipData.TotalHealth;
    }

    void Update()
    {
        if (health <= 0)
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
        if (this.charType == CharType.PLAYER)
        {
            
        }

        StartCoroutine(DestroyShip());
    }
    
    IEnumerator DestroyShip()
    {
        GetComponent<Rigidbody2D>().Sleep();

        yield return new WaitForSeconds(5f);
        this.gameObject.SetActive(false);
        // TODO: create method to replenish the enemy spawn 
    }

    
    public int Health { get { return health; } }
}
